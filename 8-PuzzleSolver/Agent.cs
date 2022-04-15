using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_PuzzleSolver
{
    public class Agent
    {
        public Stopwatch sw = new Stopwatch();
        public bool stopSearching = false;
        
        public List<Action> BreadthFirstAlgorithm(State currentState,State goalState, Label exnodesinfo,Label exnodesinfoResult, Label currentFringenodesinf,Label timeinfo,Label maxfringeinfo)
        {
            //Empty Action Sequence.
            List<Action> actionSequence = new List<Action>();

            sw.Start();
            int maxFringeSize = 0;
            stopSearching = false;


            //Create a node from first state.
            Node initNode = new Node(new Action(Action.ActionTypes.none), currentState, null);     //Since it's first node there will not be action or parentnode.

            //There will be explored nodes.
            List<Node> exploredNodes = new List<Node>();
            //There will be fringe queue contains the nodes will be explored.
            List<Node> fringeNodes = new List<Node>();
            
            
            fringeNodes.Add(initNode);
            if (fringeNodes.Count > maxFringeSize) maxFringeSize = fringeNodes.Count;

            while (fringeNodes.Count > 0 && !stopSearching)   //It will continue until all nodes explored in fringe.
            {
                //Taking the first item from list (Behave like queue)
                Node currentNode = fringeNodes[0];
                fringeNodes.RemoveAt(0);
                //Add this to the explored nodes.
                exploredNodes.Add(currentNode);
                exnodesinfo.Text = "Expanded Nodes = " + exploredNodes.Count;
                //Check the current nodes state with goal one.
                if (IsSameState(currentNode.GetNodeState(),goalState))
                {
                    //Found the final state return the action sequence.
                    while(currentNode.GetParentNode() != null)
                    {
                        actionSequence.Add(currentNode.GetNodeAction());
                        //Update the currentnode with the parent node.
                        currentNode = currentNode.GetParentNode();
                    }

                    //After loop reverse the action sequence because we added actions from end to start.
                    actionSequence.Reverse();
                    //Result part.
                    maxfringeinfo.Text = "Maximum Size of Fringe = " + maxFringeSize;


                    //Time info part.

                    sw.Stop();

                    int finalmilisec = (int)(sw.ElapsedMilliseconds % 1000);
                    double totalsec = sw.ElapsedMilliseconds / 1000;
                    int finalSec = (int)(totalsec % 60);
                    int finalMin = (int)(totalsec / 60);

                    sw.Reset();

                    exnodesinfoResult.Text = "Expanded Nodes = " + exploredNodes.Count;
                    timeinfo.Text = "Time = " + finalMin + " minutes," + finalSec + " seconds," + finalmilisec + " miliseconds";
                    return actionSequence;
                }

                //This is not the goal state.
                else
                {
                    //Determine the possible action from this nodes state.
                    List<Action> possibleActions = GetPossibleActions(currentNode.GetNodeState());
                    //Each action will generate new state.
                    for(int i =0; i < possibleActions.Count;i++) 
                    {
                        //Just checking the action that will back to old state and just continue.
                        if (possibleActions[i].GetActionType() == GetOppositeActionType(currentNode.GetNodeAction().GetActionType())) continue;

                        State generatedState = GenerateNewState(currentNode.GetNodeState(), possibleActions[i]);
                        //If this states not in explored ones, create new nodes from them and add to the fringe.
                        bool stateExist = false;
                        for (int j = 0; j < exploredNodes.Count; j++)
                        {

                            if (IsSameState(exploredNodes[j].GetNodeState(), generatedState))
                            {
                                stateExist = true;                                                         
                                break;
                            }
                        }
                        
                        //Second control for fringe nodes.
                        if(!stateExist)
                        {
                            for(int j =0; j< fringeNodes.Count;j++)
                            {
                                if(IsSameState(fringeNodes[j].GetNodeState(),generatedState))
                                {
                                    stateExist = true;
                                    break;
                                }
                            }
                        }


                        if (!stateExist)
                        {
                            //Create new node from this state and action.
                            Node newNode = new Node(possibleActions[i], generatedState, currentNode);
                            fringeNodes.Add(newNode);   //Add to the fringe.
                            if (fringeNodes.Count > maxFringeSize) maxFringeSize = fringeNodes.Count;
                            currentFringenodesinf.Text = "Fringe count = " + fringeNodes.Count;
                        }
                    }
                }     
            }

            //Time info part.

            sw.Stop();

            int finalmilisec2 = (int)(sw.ElapsedMilliseconds % 1000);
            double totalsec2 = sw.ElapsedMilliseconds / 1000;
            int finalSec2 = (int)(totalsec2 % 60);
            int finalMin2 = (int)(totalsec2 / 60);

            sw.Reset();

            exnodesinfoResult.Text = "Expanded Nodes = " + exploredNodes.Count;
            timeinfo.Text = "Time = " + finalMin2 + " minutes," + finalSec2 + " seconds," + finalmilisec2 + " miliseconds";
            maxfringeinfo.Text = "Maximum Size of Fringe = " + maxFringeSize;

            //If couldn't find in the loop just return null.
            return null;
        }

        public List<Action> DepthFirstAlgorithm(State currentState, State goalState, Label exnodesinfo, Label exnodesinfoResult, Label currentFringenodesinf, Label timeinfo, Label maxfringeinfo)
        {
            //Empty Action Sequence.
            List<Action> actionSequence = new List<Action>();

            sw.Start();
            int maxFringeSize = 0;
            stopSearching = false;

            //Create a node from first state.
            Node initNode = new Node(new Action(Action.ActionTypes.none), currentState, null);     //Since it's first node there will not be action or parentnode.

            //There will be explored nodes.
            List<Node> exploredNodes = new List<Node>();
            //There will be fringe queue contains the nodes will be explored.
            List<Node> fringeNodes = new List<Node>();

            fringeNodes.Add(initNode);
            
            if (fringeNodes.Count > maxFringeSize) maxFringeSize = fringeNodes.Count;

            while (fringeNodes.Count > 0 && !stopSearching)   //It will continue until all nodes explored in fringe.
            {
                //Taking the last object from the list (behave like stack)
                Node currentNode = fringeNodes[fringeNodes.Count - 1];
                fringeNodes.RemoveAt(fringeNodes.Count - 1);    //Pop up last item from  the list.
                //Add this to the explored nodes.
                exploredNodes.Add(currentNode);     
                exnodesinfo.Text = "Expanded Nodes = " + exploredNodes.Count;
                //Check the current nodes state with goal one.
                if (IsSameState(currentNode.GetNodeState(), goalState))
                {
                    //Found the final state return the action sequence.
                    while (currentNode.GetParentNode() != null)
                    {
                        actionSequence.Add(currentNode.GetNodeAction());
                        //Update the currentnode with the parent node.
                        currentNode = currentNode.GetParentNode();
                    }

                    //After loop reverse the action sequence because we added actions from end to start.
                    actionSequence.Reverse();
                    //Result part.
                    maxfringeinfo.Text = "Maximum Size of Fringe = " + maxFringeSize;


                    //Time info part.

                    sw.Stop();

                    int finalmilisec = (int)(sw.ElapsedMilliseconds % 1000);
                    double totalsec = sw.ElapsedMilliseconds / 1000;
                    int finalSec = (int)(totalsec % 60);
                    int finalMin = (int)(totalsec / 60);

                    sw.Reset();

                    exnodesinfoResult.Text = "Expanded Nodes = " + exploredNodes.Count;
                    timeinfo.Text = "Time = " + finalMin + " minutes," + finalSec + " seconds," + finalmilisec + " miliseconds";
                    return actionSequence;
                }

                //This is not the goal state.
                else
                {
                    //Determine the possible action from this nodes state.
                    List<Action> possibleActions = GetPossibleActions(currentNode.GetNodeState());
                    //Each action will generate new state.
                    for (int i = 0; i < possibleActions.Count; i++)  
                    {
                        //Just checking the action that will back to old state and just continue.
                        if (possibleActions[i].GetActionType() == GetOppositeActionType(currentNode.GetNodeAction().GetActionType())) continue;

                        State generatedState = GenerateNewState(currentNode.GetNodeState(), possibleActions[i]);
                        //If this states not in explored ones, create new nodes from them and add to the fringe.
                        bool stateExist = false;
                        for (int j = 0; j < exploredNodes.Count; j++)
                        {

                            if (IsSameState(exploredNodes[j].GetNodeState(), generatedState))
                            {
                                stateExist = true;
                                break;
                            }
                        }


                        //Second control for fringe nodes.
                        if (!stateExist)
                        {
                            for (int j = 0; j < fringeNodes.Count; j++)
                            {
                                if (IsSameState(fringeNodes[j].GetNodeState(), generatedState))
                                {
                                    stateExist = true;                          
                                    break;
                                }
                            }
                        }

                        if (!stateExist)
                        {
                            //Create new node from this state and action.
                            Node newNode = new Node(possibleActions[i], generatedState, currentNode);
                            //Add to the fringe.
                            fringeNodes.Add(newNode);
                            if (fringeNodes.Count > maxFringeSize) maxFringeSize = fringeNodes.Count;
                            currentFringenodesinf.Text = "Fringe count = " + fringeNodes.Count;
                        }
                    }
                }
            }

            //Time info part.

            sw.Stop();

            int finalmilisec2 = (int)(sw.ElapsedMilliseconds % 1000);
            double totalsec2 = sw.ElapsedMilliseconds / 1000;
            int finalSec2 = (int)(totalsec2 % 60);
            int finalMin2 = (int)(totalsec2 / 60);

            exnodesinfoResult.Text = "Expanded Nodes = " + exploredNodes.Count;
            timeinfo.Text = "Time = " + finalMin2 + " minutes," + finalSec2 + " seconds," + finalmilisec2 + " miliseconds";
            maxfringeinfo.Text = "Maximum Size of Fringe = " + maxFringeSize;

            sw.Reset();

            //If couldn't find in the loop just return null.

            return null;
        }

        public List<Action> DepthLimitAlgorithm(State currentState, State goalState, Label exnodesinfo, Label exnodesinfoResult, Label currentFringenodesinf, Label timeinfo, Label maxfringeinfo,int depthLimit)
        {
            //Empty Action Sequence.
            List<Action> actionSequence = new List<Action>();

            sw.Start();
            int maxFringeSize = 0;
            stopSearching = false;

            //Create a node from first state.
            Node initNode = new Node(new Action(Action.ActionTypes.none), currentState, null);     //Since it's first node there will not be action or parentnode.
            initNode.Depth = 0;
            //There will be explored nodes.
            List<Node> exploredNodes = new List<Node>();
            //There will be fringe queue contains the nodes will be explored.
            List<Node> fringeNodes = new List<Node>();

            fringeNodes.Add(initNode);

            if (fringeNodes.Count > maxFringeSize) maxFringeSize = fringeNodes.Count;

            while (fringeNodes.Count > 0 && !stopSearching)   //It will continue until all nodes explored in fringe.
            {
                //Dequeue node from the queue.
                
                Node currentNode = fringeNodes[fringeNodes.Count - 1];
                fringeNodes.RemoveAt(fringeNodes.Count - 1);    //Pop up last item from  the list.
                //Add this to the explored nodes.
                exploredNodes.Add(currentNode);
                exnodesinfo.Text = "Expanded Nodes = " + exploredNodes.Count;
                //Check the current nodes state with goal one.
                if (IsSameState(currentNode.GetNodeState(), goalState))
                {
                    //Found the final state return the action sequence.
                    while (currentNode.GetParentNode() != null)
                    {
                        actionSequence.Add(currentNode.GetNodeAction());
                        //Update the currentnode with the parent node.
                        currentNode = currentNode.GetParentNode();
                    }

                    //After loop reverse the action sequence because we added actions from end to start.
                    actionSequence.Reverse();
                    //Result part.
                    maxfringeinfo.Text = "Maximum Size of Fringe = " + maxFringeSize;


                    //Time info part.

                    sw.Stop();

                    int finalmilisec = (int)(sw.ElapsedMilliseconds % 1000);
                    double totalsec = sw.ElapsedMilliseconds / 1000;
                    int finalSec = (int)(totalsec % 60);
                    int finalMin = (int)(totalsec / 60);
                    sw.Reset();

                    exnodesinfoResult.Text = "Expanded Nodes = " + exploredNodes.Count;
                    timeinfo.Text = "Time = " + finalMin + " minutes," + finalSec + " seconds," + finalmilisec + " miliseconds";
                    return actionSequence;
                }

                //This is not the goal state.
                else
                {
                    //Check the depth before expanding the current node, if reach the depth limit stop and continue checking the other nodes.
                    if (currentNode.Depth > depthLimit) continue;
                    //Determine the possible action from this nodes state.
                    List<Action> possibleActions = GetPossibleActions(currentNode.GetNodeState());
                    //Each action will generate new state.
                    for (int i = 0; i < possibleActions.Count; i++)  
                    {
                        //Just checking the action that will back to old state and just continue.
                        if (possibleActions[i].GetActionType() == GetOppositeActionType(currentNode.GetNodeAction().GetActionType())) continue;

                        State generatedState = GenerateNewState(currentNode.GetNodeState(), possibleActions[i]);
                        //If this states not in explored ones, create new nodes from them and add to the fringe.
                        bool stateExist = false;
                        for (int j = 0; j < exploredNodes.Count; j++)
                        {

                            if (IsSameState(exploredNodes[j].GetNodeState(), generatedState))
                            {
                                stateExist = true;
                                break;
                            }
                        }

                        //Second control for fringe nodes.
                        if (!stateExist)
                        {
                            for (int j = 0; j < fringeNodes.Count; j++)
                            {
                                if (IsSameState(fringeNodes[j].GetNodeState(), generatedState))
                                {
                                    stateExist = true;
                                    break;
                                }
                            }
                        }

                        if (!stateExist)
                        {
                            //Create new node from this state and action.
                            Node newNode = new Node(possibleActions[i], generatedState, currentNode);
                            //Add to the fringe.
                            fringeNodes.Add(newNode);
                            if (fringeNodes.Count > maxFringeSize) maxFringeSize = fringeNodes.Count;
                            currentFringenodesinf.Text = "Fringe count = " + fringeNodes.Count;
                        }
                    }
                }
            }

            //Time info part.

            sw.Stop();

            int finalmilisec2 = (int)(sw.ElapsedMilliseconds % 1000);
            double totalsec2 = sw.ElapsedMilliseconds / 1000;
            int finalSec2 = (int)(totalsec2 % 60);
            int finalMin2 = (int)(totalsec2 / 60);
            sw.Reset();

            exnodesinfoResult.Text = "Expanded Nodes = " + exploredNodes.Count;
            timeinfo.Text = "Time = " + finalMin2 + " minutes," + finalSec2 + " seconds," + finalmilisec2 + " miliseconds";
            maxfringeinfo.Text = "Maximum Size of Fringe = " + maxFringeSize;

            //If couldn't find in the loop just return null.
            
            return null;
        }

        //This one is for iterative searching.
        public List<Action> DepthLimitAlgorithm(State currentState, State goalState, Label exnodesinfo, Label exnodesinfoResult, Label currentFringenodesinf, Label timeinfo, Label maxfringeinfo, int depthLimit,out int maxexplorednode, out int maxFringenode)
        {
            //Empty Action Sequence.
            List<Action> actionSequence = new List<Action>();

            sw.Start();
            int maxFringeSize = 0;
            stopSearching = false;

            maxexplorednode = 0;
            maxFringenode = 0;

            //Create a node from first state.
            Node initNode = new Node(new Action(Action.ActionTypes.none), currentState, null);     //Since it's first node there will not be action or parentnode.
            initNode.Depth = 0;
            //There will be explored nodes.
            List<Node> exploredNodes = new List<Node>();
            //There will be fringe queue contains the nodes will be explored.
            List<Node> fringeNodes = new List<Node>();

            fringeNodes.Add(initNode);

            if (fringeNodes.Count > maxFringeSize) maxFringeSize = fringeNodes.Count;

            while (fringeNodes.Count > 0 && !stopSearching)   //It will continue until all nodes explored in fringe.
            {
                //Dequeue node from the queue.

                Node currentNode = fringeNodes[fringeNodes.Count - 1];
                fringeNodes.RemoveAt(fringeNodes.Count - 1);    //Pop up last item from  the list.
                //Add this to the explored nodes.
                exploredNodes.Add(currentNode);
                exnodesinfo.Text = "Expanded Nodes = " + exploredNodes.Count;
                //Check the current nodes state with goal one.
                if (IsSameState(currentNode.GetNodeState(), goalState))
                {
                    //Found the final state return the action sequence.
                    while (currentNode.GetParentNode() != null)
                    {
                        actionSequence.Add(currentNode.GetNodeAction());
                        //Update the currentnode with the parent node.
                        currentNode = currentNode.GetParentNode();
                    }

                    //After loop reverse the action sequence because we added actions from end to start.
                    actionSequence.Reverse();
                    //Result part.
                    maxfringeinfo.Text = "Maximum Size of Fringe = " + maxFringeSize;
                    maxFringenode = maxFringeSize;

                    //Time info part.

                    sw.Stop();

                    int finalmilisec = (int)(sw.ElapsedMilliseconds % 1000);
                    double totalsec = sw.ElapsedMilliseconds / 1000;
                    int finalSec = (int)(totalsec % 60);
                    int finalMin = (int)(totalsec / 60);
                    sw.Reset();

                    maxexplorednode = exploredNodes.Count;               
                    exnodesinfoResult.Text = "Expanded Nodes = " + exploredNodes.Count;
                    timeinfo.Text = "Time = " + finalMin + " minutes," + finalSec + " seconds," + finalmilisec + " miliseconds";
                    return actionSequence;
                }

                //This is not the goal state.
                else
                {
                    //Check the depth before expanding the current node, if reach the depth limit stop and continue checking the other nodes.
                    if (currentNode.Depth > depthLimit) continue;
                    //Determine the possible action from this nodes state.
                    List<Action> possibleActions = GetPossibleActions(currentNode.GetNodeState());
                    //Each action will generate new state.
                    for (int i = 0; i < possibleActions.Count; i++)    //TODO durumu eski parent durumuna dönüştüren aksiyonu yoksay onu kontrol etme.
                    {
                        //Just checking the action that will back to old state and just continue.
                        if (possibleActions[i].GetActionType() == GetOppositeActionType(currentNode.GetNodeAction().GetActionType())) continue;

                        State generatedState = GenerateNewState(currentNode.GetNodeState(), possibleActions[i]);
                        //If this states not in explored ones, create new nodes from them and add to the fringe.
                        bool stateExist = false;
                        for (int j = 0; j < exploredNodes.Count; j++)
                        {

                            if (IsSameState(exploredNodes[j].GetNodeState(), generatedState))
                            {
                                stateExist = true;
                                break;
                            }
                        }

                        //Second control for fringe nodes.
                        if (!stateExist)
                        {
                            for (int j = 0; j < fringeNodes.Count; j++)
                            {
                                if (IsSameState(fringeNodes[j].GetNodeState(), generatedState))
                                {
                                    stateExist = true;
                                    break;
                                }
                            }
                        }

                        if (!stateExist)
                        {
                            //Create new node from this state and action.
                            Node newNode = new Node(possibleActions[i], generatedState, currentNode);
                            //Add to the fringe.
                            fringeNodes.Add(newNode);
                            if (fringeNodes.Count > maxFringeSize) maxFringeSize = fringeNodes.Count;
                            currentFringenodesinf.Text = "Fringe count = " + fringeNodes.Count;
                        }
                    }
                }
            }

            //Time info part.

            sw.Stop();

            int finalmilisec2 = (int)(sw.ElapsedMilliseconds % 1000);
            double totalsec2 = sw.ElapsedMilliseconds / 1000;
            int finalSec2 = (int)(totalsec2 % 60);
            int finalMin2 = (int)(totalsec2 / 60);
            sw.Reset();

            maxFringenode = maxFringeSize;
            maxexplorednode = exploredNodes.Count;

            exnodesinfoResult.Text = "Expanded Nodes = " + exploredNodes.Count;
            timeinfo.Text = "Time = " + finalMin2 + " minutes," + finalSec2 + " seconds," + finalmilisec2 + " miliseconds";
            maxfringeinfo.Text = "Maximum Size of Fringe = " + maxFringeSize;

            //If couldn't find in the loop just return null.

            return null;
        }


        public List<Action> IterativeDeepeningAlgorithm(State currentState, State goalState, Label exnodesinfo, Label exnodesinfoResult, Label currentFringenodesinf, Label timeinfo, Label maxfringeinfo)
        {
            int currentDepthLimit = 1;
            bool resultFound = false;
            List<Action> resultActionSequence = null;
            stopSearching = false;

            Stopwatch newsw = new Stopwatch();

            int totalexplorednode = 0;
            int maxfringenode = 0;

            newsw.Start();

            while(!stopSearching)
            {
                
                resultActionSequence = DepthLimitAlgorithm(currentState, goalState, exnodesinfo,exnodesinfoResult, currentFringenodesinf, timeinfo, maxfringeinfo,currentDepthLimit, out int maxexpnode,out int maxfnode);

                totalexplorednode += maxexpnode;
                if (maxfringenode < maxfnode) maxfringenode = maxfnode;
                if(resultActionSequence == null)
                {
                    currentDepthLimit++;       //Increase depth limit and continue searching.        
                    continue;
                }

                //Result found.
                else 
                {
                    //Time info part.

                    newsw.Stop();

                    int finalmilisec = (int)(newsw.ElapsedMilliseconds % 1000);
                    double totalsec = newsw.ElapsedMilliseconds / 1000;
                    int finalSec = (int)(totalsec % 60);
                    int finalMin = (int)(totalsec / 60);
                    newsw.Reset();


                    exnodesinfoResult.Text = "Expanded Nodes = " + totalexplorednode;
                    maxfringeinfo.Text = "Maximum Size of Fringe = " + maxfringenode;
                    timeinfo.Text = "Time = " + finalMin + " minutes," + finalSec + " seconds," + finalmilisec + " miliseconds";
                    return resultActionSequence;
                }
            }
            //Time info part.

            newsw.Stop();

            int finalmilisec2 = (int)(newsw.ElapsedMilliseconds % 1000);
            double totalsec2 = newsw.ElapsedMilliseconds / 1000;
            int finalSec2 = (int)(totalsec2 % 60);
            int finalMin2 = (int)(totalsec2 / 60);
            newsw.Reset();


            Console.WriteLine("iterative stop");

            exnodesinfoResult.Text = "Expanded Nodes = " + totalexplorednode;
            maxfringeinfo.Text = "Maximum Size of Fringe = " + maxfringenode;
            timeinfo.Text = "Time = " + finalMin2 + " minutes," + finalSec2 + " seconds," + finalmilisec2 + " miliseconds";


            return resultActionSequence;
        }



        public Action.ActionTypes GetOppositeActionType(Action.ActionTypes actiontype)
        {
            Action.ActionTypes result = Action.ActionTypes.none;

            switch(actiontype)
            {
                case Action.ActionTypes.left:
                    result = Action.ActionTypes.right;
                    break;
                case Action.ActionTypes.right:
                    result = Action.ActionTypes.left;
                    break;
                case Action.ActionTypes.down:
                    result = Action.ActionTypes.up;
                    break;
                case Action.ActionTypes.up:
                    result = Action.ActionTypes.down;
                    break;
            }


            return result;


        }
        public bool IsSameState(State state1,State state2)
        {
            for(int i = 0; i < state1.GetTiles().Length; i++)
            {
                //If atleast one tile number different than another it returns false.
                if(state1.GetTiles()[i] != state2.GetTiles()[i])
                {
                    return false;
                }
            }
            //Else all tile values are same then return true.
            return true;
        }

        public List<Action> GetPossibleActions(State currentState)
        {
            List<Action> possibleActions = new List<Action>();

            //Find the index of the blank tile.
            int blanktileIndex = 0;
            for(int i =0; i < currentState.GetTiles().Length;i++)
            {
                if(currentState.GetTiles()[i] == 0)
                {
                    blanktileIndex = i;
                    break;
                }
            }

            //After find it create actions for this state.
            switch(blanktileIndex)
            {
                case 0:
                    possibleActions.Add(new Action(Action.ActionTypes.right));
                    possibleActions.Add(new Action(Action.ActionTypes.down));
                    break;
                case 1:
                    possibleActions.Add(new Action(Action.ActionTypes.left));
                    possibleActions.Add(new Action(Action.ActionTypes.right));
                    possibleActions.Add(new Action(Action.ActionTypes.down));
                    break;
                case 2:
                    possibleActions.Add(new Action(Action.ActionTypes.left));      
                    possibleActions.Add(new Action(Action.ActionTypes.down));
                    break;
                case 3:
                    possibleActions.Add(new Action(Action.ActionTypes.up));
                    possibleActions.Add(new Action(Action.ActionTypes.right));
                    possibleActions.Add(new Action(Action.ActionTypes.down));
                    break;
                case 4:
                    possibleActions.Add(new Action(Action.ActionTypes.left));
                    possibleActions.Add(new Action(Action.ActionTypes.right));
                    possibleActions.Add(new Action(Action.ActionTypes.up));
                    possibleActions.Add(new Action(Action.ActionTypes.down));
                    break;
                case 5:
                    possibleActions.Add(new Action(Action.ActionTypes.left));      
                    possibleActions.Add(new Action(Action.ActionTypes.up));
                    possibleActions.Add(new Action(Action.ActionTypes.down));
                    break;
                case 6:
                    possibleActions.Add(new Action(Action.ActionTypes.right));
                    possibleActions.Add(new Action(Action.ActionTypes.up));
                    break;
                case 7:
                    possibleActions.Add(new Action(Action.ActionTypes.left));
                    possibleActions.Add(new Action(Action.ActionTypes.up));
                    possibleActions.Add(new Action(Action.ActionTypes.right));
                    break;
                case 8:
                    possibleActions.Add(new Action(Action.ActionTypes.left));
                    possibleActions.Add(new Action(Action.ActionTypes.up));
                    break;

            }

            return possibleActions;
        }


        public State GenerateNewState(State currentState, Action action)
        {

            int[] newtile = new int[9];
            //Create new tile and copy the values from currentState.
            for(int i= 0; i < newtile.Length;i++)
            {
                newtile[i] = currentState.GetTiles()[i];
            }


            //Find the blank tile which it's 0 value and change to values with the given action.
            for(int i = 0; i  < newtile.Length;i++)
            {
                if(newtile[i] == 0) //This is the blank tile, replaced it.
                {
                    int tempValue = 0;
                    switch(action.GetActionType())
                    {
                        case Action.ActionTypes.left:
                            tempValue = newtile[i - 1];
                            newtile[i - 1] = 0; //New blank tile.
                            newtile[i] = tempValue;
                        break;
                        case Action.ActionTypes.right:
                            tempValue = newtile[i + 1];
                            newtile[i + 1] = 0; //New blank tile.
                            newtile[i] = tempValue;
                            break;
                        case Action.ActionTypes.up:
                            tempValue = newtile[i - 3];
                            newtile[i - 3] = 0; //New blank tile.
                            newtile[i] = tempValue;
                            break;
                        case Action.ActionTypes.down:
                            tempValue = newtile[i + 3];
                            newtile[i + 3] = 0; //New blank tile.
                            newtile[i] = tempValue;
                            break;
                    }

                    break;
                }
            }

            return new State(newtile);
        }
    }
}

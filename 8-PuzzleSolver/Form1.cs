using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_PuzzleSolver
{
    public partial class Form1 : Form
    {

        private State currentState;
        private State selectedState = new State(new int[9]);
        private State goalState;
        Agent agent;
        private List<Action> actionSequence;
        private int actionSeqIndex = 0;
        Random rnd = new Random();
        private List<Label> tiles = new List<Label>();

        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();

            ActivateMainMenuUI();


            tiles.Add(tile0);
            tiles.Add(tile1);
            tiles.Add(tile2);
            tiles.Add(tile3);
            tiles.Add(tile4);
            tiles.Add(tile5);
            tiles.Add(tile6);
            tiles.Add(tile7);
            tiles.Add(tile8);

            

             agent = new Agent();

            int[] emptyTiles = new int[9];
            currentState = new State(emptyTiles);
            //GenerateNewState();
            List<int> numbers = new List<int>();
            for (int i = 0; i < 9; i++)
            {
                numbers.Add(i);
            }

            currentState.GetTiles()[0] = 1;
            currentState.GetTiles()[1] = 4;
            currentState.GetTiles()[2] = 2;
            currentState.GetTiles()[3] = 3;
            currentState.GetTiles()[4] = 7;
            currentState.GetTiles()[5] = 5;
            currentState.GetTiles()[6] = 6;
            currentState.GetTiles()[7] = 0;
            currentState.GetTiles()[8] = 8;


            UpdatePuzzle(currentState);

            //Goal state manually.
            int[] goalTiles = new int[9];
            for (int i = 0; i < goalTiles.Length; i++)
            {
                goalTiles[i] = i;
            }
            goalState = new State(goalTiles);

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void generateButton_Click(object sender, EventArgs e)
        {
            warningLabel.Visible = false;
            GenerateNewState();
            while(!IsStateSolvable(currentState))
            {
                GenerateNewState();
            }
            UpdatePuzzle(currentState);
        }

        public void GenerateNewState()
        {
            // Generate another tiles randomly.

            List<int> numbers = new List<int>();
            for(int i =0; i < 9; i++)
            {
                numbers.Add(i);
            }

            for(int i =0; i < currentState.GetTiles().Length; i++)
            {
                int rndIndex = rnd.Next(0, numbers.Count);
                currentState.GetTiles()[i] = numbers[rndIndex];
                numbers.RemoveAt(rndIndex);
            }        
        }

        public bool IsStateSolvable(State state)
        {
            int invCount = 0;

            for(int i = 0; i < 8; i++)
            {
                if (state.GetTiles()[i] == 0) continue;
                for(int j = i+1; j < 9; j++)
                {
                    if (state.GetTiles()[j] == 0) continue;
                    if(state.GetTiles()[i] > state.GetTiles()[j])
                    {
                        invCount++;
                    }
                }
            }


            Console.WriteLine(invCount);

            if (invCount % 2 == 0) return true;

            //Else
            return false;



        }

        public void UpdatePuzzle(State state)
        {
            for(int i = 0; i < tiles.Count; i++)
            {
                if (state.GetTiles()[i] != 0)    
                    tiles[i].Text = state.GetTiles()[i].ToString();
                else tiles[i].Text = "";
            }
        }

        public void ActivateMainMenuUI()
        {
            actionSeqIndex = 0;
            algoTypesMenu.SelectedIndex = 0;

            mainPanel1.Visible = true;
            mainPanel2.Visible = true;

            UpdatePuzzle(currentState);

            DeActivateResultMenuUI();
            DeActivateSolvingMenuUI();

            depthlimitinfo.Visible = false;
            depthLimVal.Visible = false;
            deptlimitlabel.Visible = false;
            warningLabel.Visible = false;

        }

        public void DeActivateMainMenuUI()
        {

            mainPanel1.Visible = false;
            mainPanel2.Visible = false;

        }

        public void ActivateResultMenuUI()
        {
            resultsPanel2.Visible = true;
            backMainScreen.Visible = true;

            DeActivateMainMenuUI();
            DeActivateSolvingMenuUI();
        }

        public void DeActivateResultMenuUI()
        {

            resultsPanel2.Visible = false;
            backMainScreen.Visible = false;
        }


        public void ActivateSolvingMenuUI()
        {

            calcPanel.Visible = true;

            DeActivateMainMenuUI();
            DeActivateResultMenuUI();
        }

        public void DeActivateSolvingMenuUI()
        {
            calcPanel.Visible = false;
        }


        private void solveButton_Click(object sender, EventArgs e)
        {
            //Run algorithm.          
            for(int i =0; i < 9;i++)
            {
                selectedState.GetTiles()[i] = currentState.GetTiles()[i];
            }
            ActivateSolvingMenuUI();
            backgroundWorker1.RunWorkerAsync();
            
        }

        private void backMainScreen_Click(object sender, EventArgs e)
        {
            ActivateMainMenuUI();
        }

        private void nextActionButton_Click(object sender, EventArgs e)
        {
            if (actionSequence == null) return;
            if (actionSeqIndex >= actionSequence.Count) return;
            Action currentAction = actionSequence[actionSeqIndex];
            actionSeqIndex++;
            MakeActionToSelectedState(currentAction);
            UpdatePuzzle(selectedState);
            stepsCount.Text = actionSeqIndex + "/" + actionSequence.Count.ToString();
            if (actionSeqIndex >= actionSequence.Count)
            {
                nextActionLabel.Text = "Done!";
                return;
            }
            nextActionLabel.Text = actionSequence[actionSeqIndex].GetActionType().ToString();
        }

        private void MakeActionToSelectedState(Action action)
        {
            //Find the blank tile which it's 0 value and change to values with the given action.
            for (int i = 0; i < selectedState.GetTiles().Length; i++)
            {
                if (selectedState.GetTiles()[i] == 0) //This is the blank tile, replaced it.
                {
                    int tempValue = 0;
                    switch (action.GetActionType())
                    {
                        case Action.ActionTypes.left:
                            tempValue = selectedState.GetTiles()[i - 1];
                            selectedState.GetTiles()[i - 1] = 0; //New blank tile.
                            selectedState.GetTiles()[i] = tempValue;
                            break;
                        case Action.ActionTypes.right:
                            tempValue = selectedState.GetTiles()[i + 1];
                            selectedState.GetTiles()[i + 1] = 0; //New blank tile.
                            selectedState.GetTiles()[i] = tempValue;
                            break;
                        case Action.ActionTypes.up:
                            tempValue = selectedState.GetTiles()[i - 3];
                            selectedState.GetTiles()[i - 3] = 0; //New blank tile.
                            selectedState.GetTiles()[i] = tempValue;
                            break;
                        case Action.ActionTypes.down:
                            tempValue = selectedState.GetTiles()[i + 3];
                            selectedState.GetTiles()[i + 3] = 0; //New blank tile.
                            selectedState.GetTiles()[i] = tempValue;
                            break;
                    }

                    break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void stepsCount_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void exLabel_Click(object sender, EventArgs e)
        {

        }

        private void enterManulButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(manualValueText.Text.Length);

            if(manualValueText.Text.Length != 9)
            {
                warningLabel.Visible = true;
                return;
            }


            for(int i = 0; i  < 9;i++)
            {
                int x = (int)manualValueText.Text[i] -48;   // '0' value 48.
                if(x < 0 || x > 8)
                {
                    warningLabel.Visible = true;
                    return;
                }
                Console.WriteLine(x); 
                currentState.GetTiles()[i] = x;
            }

            if (!IsStateSolvable(currentState))
            {
                warningLabel.Visible = true;
                return;
            }
                

            UpdatePuzzle(currentState);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int selectedIndex = algoTypesMenu.SelectedIndex;

            if(selectedIndex == 0)
            {
                actionSequence = agent.BreadthFirstAlgorithm(selectedState, goalState, expNodesInfo, expNodesResult, currentFringeInfo, timeLabel, maxSizeFringeLabel);
            }

            else if(selectedIndex == 1)
            {
                actionSequence = agent.DepthFirstAlgorithm(selectedState, goalState, expNodesInfo,expNodesResult, currentFringeInfo, timeLabel, maxSizeFringeLabel);
            }

            else if(selectedIndex == 2)
            {
                int selectedVal = 10;
                if(int.TryParse(depthLimVal.Text,out int result))
                {
                    selectedVal = result;
                    Console.WriteLine(selectedVal);
                }
                actionSequence = agent.DepthLimitAlgorithm(selectedState, goalState, expNodesInfo, expNodesResult, currentFringeInfo, timeLabel, maxSizeFringeLabel,selectedVal);
            }

            else if(selectedIndex == 3)
            {
                actionSequence = agent.IterativeDeepeningAlgorithm(selectedState, goalState, expNodesInfo, expNodesResult, currentFringeInfo, timeLabel, maxSizeFringeLabel);
            }

            else { actionSequence = agent.BreadthFirstAlgorithm(selectedState, goalState, expNodesInfo, expNodesResult, currentFringeInfo, timeLabel, maxSizeFringeLabel); }

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Change UI Components for Solving Screen.

            if(actionSequence == null)
            {
                //Type an error to results not founding search.
                resultWarnLabel.Visible = true;
                stepsCount.Text = "0/0";
            }

            else if (actionSequence.Count > 0)
            {
                resultWarnLabel.Visible = false;
                nextActionLabel.Text = actionSequence[0].GetActionType().ToString();
                stepsCount.Text = "0/" + actionSequence.Count.ToString();
            }
            ActivateResultMenuUI();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            agent.stopSearching = true;
        }

        private void algoTypesMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(algoTypesMenu.SelectedIndex == 2)
            {
                // Enable depth limit settings
                depthlimitinfo.Visible = true;
                depthLimVal.Visible = true;
                deptlimitlabel.Visible = true;
            }

            else
            {
                // disable depth limit settings
                depthlimitinfo.Visible = false;
                depthLimVal.Visible = false;
                deptlimitlabel.Visible = false;
            }
        }

        private void expNodesInfo_Click(object sender, EventArgs e)
        {

        }

        private void maxSizeFringeLabel_Click(object sender, EventArgs e)
        {

        }

        private void nextActionLabel_Click(object sender, EventArgs e)
        {

        }

        private void stepsLabel_Click(object sender, EventArgs e)
        {

        }

        private void depthlimitinfo_Click(object sender, EventArgs e)
        {

        }
    }
}

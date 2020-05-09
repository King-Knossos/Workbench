﻿using FillAPixRobot;
using FillAPixRobot.Interfaces;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace ConceptisPuzzles.Robot
{
    public partial class RobotBrainInfoForm : Form
    {
        public RobotBrainInfoForm()
        {
            InitializeComponent();
        }

        public RobotBrain RobotBrain { set; get; }

        private void RobotTestForm_Load(object sender, System.EventArgs e)
        {
            if (RobotBrain == null)
            {
                Close();
            }
        }

        private void _btnShowActionMemory_Click(object sender, System.EventArgs e)
        {
            StringBuilder infoText = new StringBuilder();
            foreach (IActionMemory actionMemory in RobotBrain.ActionMemoryDictonary.Values)
            {
                infoText.Append($"Action: \t {actionMemory.Action}\n");
                infoText.Append($"\t CallCount: \t {actionMemory.CallCount}\n");
                infoText.Append($"\t DifferenceCount: \t {actionMemory.DifferenceCount}\n");
                infoText.Append($"\t NoDifferenceCount: \t {actionMemory.NoDifferenceCount}\n");
                infoText.Append($"\t NegativeFeedbackCount: \t {actionMemory.NegativeFeedbackCount}\n");
                infoText.Append($"\t PositiveFeedbackCount: \t {actionMemory.PositiveFeedbackCount}\n");
                infoText.Append($"\t NegProcentualNoDifference: \t {actionMemory.NegProcentualNoDifference}\n");
                infoText.Append($"\t NegProcentualNegativeFeedback: \t {actionMemory.NegProcentualNegativeFeedback}\n");

                if (_cbxShowDifferentUnits.Checked)
                {
                    infoText.Append("\t DifferentUnits:\n");
                    foreach (var entry in actionMemory.DifferentUnits)
                    {
                        infoText.Append($"\t \t {entry.Key}\t {entry.Value} \n");
                    }
                }
                if (_cbxShowNoDifferentUnits.Checked)
                {
                    infoText.Append("\t NoDifferentUnits:\n");
                    foreach (var entry in actionMemory.NoDifferentUnits)
                    {
                        infoText.Append($"\t \t {entry.Key}\t {entry.Value} \n");
                    }
                }

                if (_cbxShowNoDifferencePattern1x1.Checked)
                {
                    infoText.Append("\t NoDifferencePattern1x1:\n");
                    foreach (var entry in actionMemory.NoDifferencePattern1x1)
                    {
                        infoText.Append($"\t \t {entry.Key}\t {entry.Value} \n");
                    }
                }

                if (_cbxShowNoDifferencePattern3x3.Checked)
                {
                    infoText.Append("\t NoDifferencePattern3x3:\n");
                    foreach (var entry in actionMemory.NoDifferencePattern3x3)
                    {
                        infoText.Append($"\t \t {entry.Key}\t {entry.Value} \n");
                    }
                }

                if (_cbxShowNegativeFeedbackUnits.Checked)
                {
                    infoText.Append("\t NegativeFeedbackUnits:\n");
                    foreach (var entry in actionMemory.NegativeFeedbackUnits)
                    {
                        infoText.Append($"\t \t {entry.Key}\t {entry.Value} \n");
                    }
                }

                if (_cbxShowPositveFeedbackUnits.Checked)
                {
                    infoText.Append("\t PositveFeedbackUnits:\n");
                    foreach (var entry in actionMemory.PositveFeedbackUnits)
                    {
                        infoText.Append($"\t \t {entry.Key}\t {entry.Value} \n");
                    }
                }

                if (_cbxShowNegativeFeedbackPattern.Checked)
                {
                    var countPattern = actionMemory.NegativeFeedbackPattern.Count;
                    var countReducedPattern = actionMemory.NegativeFeedbackPattern.Count(x => x.Value > ActionMemory.LOWER_FEEDBACK_PATTERN_COUNT);
                    infoText.Append($"\t NegativeFeedbackPattern: \t ({countReducedPattern}/{countPattern}) \n");
                    foreach (var entry in actionMemory.NegativeFeedbackPattern.OrderByDescending(x => x.Value))
                    {
                        if (entry.Value <= ActionMemory.LOWER_FEEDBACK_PATTERN_COUNT)
                        {
                            break;
                        }
                        double factorReduced = (double)entry.Value / countReducedPattern;
                        double factorOverall = (double)entry.Value / countPattern;
                        infoText.Append($"\t \t {entry.Key}\t {entry.Value} \t {factorReduced} \t {factorOverall} \n");
                    }
                }
            }
            _txtInfoOutput.Text += infoText.ToString();
        }
    }
}

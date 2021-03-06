﻿namespace ConceptisPuzzles.Robot
{
    partial class RobotBrainInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._btnShowActionMemory = new System.Windows.Forms.Button();
            this._txtInfoOutput = new System.Windows.Forms.RichTextBox();
            this._cbxShowDifferentUnits = new System.Windows.Forms.CheckBox();
            this._cbxShowNegativeFeedbackUnits = new System.Windows.Forms.CheckBox();
            this._cbxShowPositveFeedbackUnits = new System.Windows.Forms.CheckBox();
            this._cbxShowNoDifferencePattern3x3 = new System.Windows.Forms.CheckBox();
            this._cbxShowNoDifferencePattern1x1 = new System.Windows.Forms.CheckBox();
            this._cbxShowNoDifferentUnits = new System.Windows.Forms.CheckBox();
            this._cbxClearBefore = new System.Windows.Forms.CheckBox();
            this._btnCleanNegativeFeedbackUnits = new System.Windows.Forms.Button();
            this._btnCleanPositiveFeedbackUnits = new System.Windows.Forms.Button();
            this._btnSaveMemories = new System.Windows.Forms.Button();
            this._btnLoadMemories = new System.Windows.Forms.Button();
            this._openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this._saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this._chbAppendMemory = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // _btnShowActionMemory
            // 
            this._btnShowActionMemory.Location = new System.Drawing.Point(12, 12);
            this._btnShowActionMemory.Name = "_btnShowActionMemory";
            this._btnShowActionMemory.Size = new System.Drawing.Size(127, 23);
            this._btnShowActionMemory.TabIndex = 0;
            this._btnShowActionMemory.Text = "Show action memory";
            this._btnShowActionMemory.UseVisualStyleBackColor = true;
            this._btnShowActionMemory.Click += new System.EventHandler(this._btnShowActionMemory_Click);
            // 
            // _txtInfoOutput
            // 
            this._txtInfoOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtInfoOutput.Location = new System.Drawing.Point(4, 62);
            this._txtInfoOutput.Name = "_txtInfoOutput";
            this._txtInfoOutput.Size = new System.Drawing.Size(1208, 394);
            this._txtInfoOutput.TabIndex = 1;
            this._txtInfoOutput.Text = "";
            // 
            // _cbxShowDifferentUnits
            // 
            this._cbxShowDifferentUnits.AutoSize = true;
            this._cbxShowDifferentUnits.Location = new System.Drawing.Point(145, 16);
            this._cbxShowDifferentUnits.Name = "_cbxShowDifferentUnits";
            this._cbxShowDifferentUnits.Size = new System.Drawing.Size(93, 17);
            this._cbxShowDifferentUnits.TabIndex = 2;
            this._cbxShowDifferentUnits.Text = "Different Units";
            this._cbxShowDifferentUnits.UseVisualStyleBackColor = true;
            // 
            // _cbxShowNegativeFeedbackUnits
            // 
            this._cbxShowNegativeFeedbackUnits.AutoSize = true;
            this._cbxShowNegativeFeedbackUnits.Checked = true;
            this._cbxShowNegativeFeedbackUnits.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbxShowNegativeFeedbackUnits.Location = new System.Drawing.Point(430, 16);
            this._cbxShowNegativeFeedbackUnits.Name = "_cbxShowNegativeFeedbackUnits";
            this._cbxShowNegativeFeedbackUnits.Size = new System.Drawing.Size(147, 17);
            this._cbxShowNegativeFeedbackUnits.TabIndex = 3;
            this._cbxShowNegativeFeedbackUnits.Text = "Negative Feedback Units";
            this._cbxShowNegativeFeedbackUnits.UseVisualStyleBackColor = true;
            // 
            // _cbxShowPositveFeedbackUnits
            // 
            this._cbxShowPositveFeedbackUnits.AutoSize = true;
            this._cbxShowPositveFeedbackUnits.Checked = true;
            this._cbxShowPositveFeedbackUnits.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbxShowPositveFeedbackUnits.Location = new System.Drawing.Point(430, 39);
            this._cbxShowPositveFeedbackUnits.Name = "_cbxShowPositveFeedbackUnits";
            this._cbxShowPositveFeedbackUnits.Size = new System.Drawing.Size(139, 17);
            this._cbxShowPositveFeedbackUnits.TabIndex = 4;
            this._cbxShowPositveFeedbackUnits.Text = "Positve Feedback Units";
            this._cbxShowPositveFeedbackUnits.UseVisualStyleBackColor = true;
            // 
            // _cbxShowNoDifferencePattern3x3
            // 
            this._cbxShowNoDifferencePattern3x3.AutoSize = true;
            this._cbxShowNoDifferencePattern3x3.Location = new System.Drawing.Point(266, 39);
            this._cbxShowNoDifferencePattern3x3.Name = "_cbxShowNoDifferencePattern3x3";
            this._cbxShowNoDifferencePattern3x3.Size = new System.Drawing.Size(149, 17);
            this._cbxShowNoDifferencePattern3x3.TabIndex = 6;
            this._cbxShowNoDifferencePattern3x3.Text = "No Difference Pattern 3x3";
            this._cbxShowNoDifferencePattern3x3.UseVisualStyleBackColor = true;
            // 
            // _cbxShowNoDifferencePattern1x1
            // 
            this._cbxShowNoDifferencePattern1x1.AutoSize = true;
            this._cbxShowNoDifferencePattern1x1.Location = new System.Drawing.Point(266, 16);
            this._cbxShowNoDifferencePattern1x1.Name = "_cbxShowNoDifferencePattern1x1";
            this._cbxShowNoDifferencePattern1x1.Size = new System.Drawing.Size(149, 17);
            this._cbxShowNoDifferencePattern1x1.TabIndex = 7;
            this._cbxShowNoDifferencePattern1x1.Text = "No Difference Pattern 1x1";
            this._cbxShowNoDifferencePattern1x1.UseVisualStyleBackColor = true;
            // 
            // _cbxShowNoDifferentUnits
            // 
            this._cbxShowNoDifferentUnits.AutoSize = true;
            this._cbxShowNoDifferentUnits.Location = new System.Drawing.Point(145, 39);
            this._cbxShowNoDifferentUnits.Name = "_cbxShowNoDifferentUnits";
            this._cbxShowNoDifferentUnits.Size = new System.Drawing.Size(110, 17);
            this._cbxShowNoDifferentUnits.TabIndex = 8;
            this._cbxShowNoDifferentUnits.Text = "No Different Units";
            this._cbxShowNoDifferentUnits.UseVisualStyleBackColor = true;
            // 
            // _cbxClearBefore
            // 
            this._cbxClearBefore.AutoSize = true;
            this._cbxClearBefore.Checked = true;
            this._cbxClearBefore.CheckState = System.Windows.Forms.CheckState.Checked;
            this._cbxClearBefore.Location = new System.Drawing.Point(12, 41);
            this._cbxClearBefore.Name = "_cbxClearBefore";
            this._cbxClearBefore.Size = new System.Drawing.Size(83, 17);
            this._cbxClearBefore.TabIndex = 9;
            this._cbxClearBefore.Text = "Clear before";
            this._cbxClearBefore.UseVisualStyleBackColor = true;
            // 
            // _btnCleanNegativeFeedbackUnits
            // 
            this._btnCleanNegativeFeedbackUnits.Location = new System.Drawing.Point(583, 12);
            this._btnCleanNegativeFeedbackUnits.Name = "_btnCleanNegativeFeedbackUnits";
            this._btnCleanNegativeFeedbackUnits.Size = new System.Drawing.Size(178, 23);
            this._btnCleanNegativeFeedbackUnits.TabIndex = 10;
            this._btnCleanNegativeFeedbackUnits.Text = "Clean negative feedback units";
            this._btnCleanNegativeFeedbackUnits.UseVisualStyleBackColor = true;
            this._btnCleanNegativeFeedbackUnits.Click += new System.EventHandler(this._btnCleanNegativeFeedbackUnits_Click);
            // 
            // _btnCleanPositiveFeedbackUnits
            // 
            this._btnCleanPositiveFeedbackUnits.Location = new System.Drawing.Point(583, 35);
            this._btnCleanPositiveFeedbackUnits.Name = "_btnCleanPositiveFeedbackUnits";
            this._btnCleanPositiveFeedbackUnits.Size = new System.Drawing.Size(178, 23);
            this._btnCleanPositiveFeedbackUnits.TabIndex = 11;
            this._btnCleanPositiveFeedbackUnits.Text = "Clean positive feedback units";
            this._btnCleanPositiveFeedbackUnits.UseVisualStyleBackColor = true;
            this._btnCleanPositiveFeedbackUnits.Click += new System.EventHandler(this._btnCleanPositiveFeedbackUnits_Click);
            // 
            // _btnSaveMemories
            // 
            this._btnSaveMemories.Location = new System.Drawing.Point(789, 35);
            this._btnSaveMemories.Name = "_btnSaveMemories";
            this._btnSaveMemories.Size = new System.Drawing.Size(75, 23);
            this._btnSaveMemories.TabIndex = 12;
            this._btnSaveMemories.Text = "Save";
            this._btnSaveMemories.UseVisualStyleBackColor = true;
            this._btnSaveMemories.Click += new System.EventHandler(this._btnSaveMemories_Click);
            // 
            // _btnLoadMemories
            // 
            this._btnLoadMemories.Location = new System.Drawing.Point(789, 10);
            this._btnLoadMemories.Name = "_btnLoadMemories";
            this._btnLoadMemories.Size = new System.Drawing.Size(75, 23);
            this._btnLoadMemories.TabIndex = 13;
            this._btnLoadMemories.Text = "Load";
            this._btnLoadMemories.UseVisualStyleBackColor = true;
            this._btnLoadMemories.Click += new System.EventHandler(this._btnLoadMemories_Click);
            // 
            // _chbAppendMemory
            // 
            this._chbAppendMemory.AutoSize = true;
            this._chbAppendMemory.Location = new System.Drawing.Point(870, 14);
            this._chbAppendMemory.Name = "_chbAppendMemory";
            this._chbAppendMemory.Size = new System.Drawing.Size(63, 17);
            this._chbAppendMemory.TabIndex = 14;
            this._chbAppendMemory.Text = "Append";
            this._chbAppendMemory.UseVisualStyleBackColor = true;
            // 
            // RobotBrainInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 461);
            this.Controls.Add(this._chbAppendMemory);
            this.Controls.Add(this._btnLoadMemories);
            this.Controls.Add(this._btnSaveMemories);
            this.Controls.Add(this._btnCleanPositiveFeedbackUnits);
            this.Controls.Add(this._btnCleanNegativeFeedbackUnits);
            this.Controls.Add(this._cbxClearBefore);
            this.Controls.Add(this._cbxShowNoDifferentUnits);
            this.Controls.Add(this._cbxShowNoDifferencePattern1x1);
            this.Controls.Add(this._cbxShowNoDifferencePattern3x3);
            this.Controls.Add(this._cbxShowPositveFeedbackUnits);
            this.Controls.Add(this._cbxShowNegativeFeedbackUnits);
            this.Controls.Add(this._cbxShowDifferentUnits);
            this.Controls.Add(this._txtInfoOutput);
            this.Controls.Add(this._btnShowActionMemory);
            this.Name = "RobotBrainInfoForm";
            this.Text = "RobotTestForm";
            this.Load += new System.EventHandler(this.RobotTestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnShowActionMemory;
        private System.Windows.Forms.RichTextBox _txtInfoOutput;
        private System.Windows.Forms.CheckBox _cbxShowDifferentUnits;
        private System.Windows.Forms.CheckBox _cbxShowNegativeFeedbackUnits;
        private System.Windows.Forms.CheckBox _cbxShowPositveFeedbackUnits;
        private System.Windows.Forms.CheckBox _cbxShowNoDifferencePattern3x3;
        private System.Windows.Forms.CheckBox _cbxShowNoDifferencePattern1x1;
        private System.Windows.Forms.CheckBox _cbxShowNoDifferentUnits;
        private System.Windows.Forms.CheckBox _cbxClearBefore;
        private System.Windows.Forms.Button _btnCleanNegativeFeedbackUnits;
        private System.Windows.Forms.Button _btnCleanPositiveFeedbackUnits;
        private System.Windows.Forms.Button _btnSaveMemories;
        private System.Windows.Forms.Button _btnLoadMemories;
        private System.Windows.Forms.OpenFileDialog _openFileDialog;
        private System.Windows.Forms.SaveFileDialog _saveFileDialog;
        private System.Windows.Forms.CheckBox _chbAppendMemory;
    }
}
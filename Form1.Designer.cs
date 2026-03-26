namespace SimpleCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAppName = new Label();
            txtCalculation = new TextBox();
            txtResult = new TextBox();
            btnNumber1 = new Button();
            btnNumber2 = new Button();
            btnNumber3 = new Button();
            btnNumber4 = new Button();
            btnNumber5 = new Button();
            btnNumber6 = new Button();
            btnNumber7 = new Button();
            btnNumber8 = new Button();
            btnNumber9 = new Button();
            btnNumber0 = new Button();
            btnClear = new Button();
            btnBackSpace = new Button();
            btnClearEntry = new Button();
            btnDivision = new Button();
            btnMultiplication = new Button();
            btnSubtraction = new Button();
            btnAddition = new Button();
            btnEquals = new Button();
            btnPMChange = new Button();
            btnPoint = new Button();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.Font = new Font("맑은 고딕", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblAppName.Location = new Point(0, 0);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(804, 127);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Simple Calculator";
            lblAppName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCalculation
            // 
            txtCalculation.Location = new Point(98, 157);
            txtCalculation.Multiline = true;
            txtCalculation.Name = "txtCalculation";
            txtCalculation.Size = new Size(610, 62);
            txtCalculation.TabIndex = 1;
            txtCalculation.TextChanged += txtCalculation_TextChanged;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(98, 254);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(610, 62);
            txtResult.TabIndex = 2;
            // 
            // btnNumber1
            // 
            btnNumber1.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnNumber1.Location = new Point(98, 439);
            btnNumber1.Name = "btnNumber1";
            btnNumber1.Size = new Size(148, 93);
            btnNumber1.TabIndex = 3;
            btnNumber1.Text = "1";
            btnNumber1.UseVisualStyleBackColor = true;
            btnNumber1.Click += NumberButton_Click;
            // 
            // btnNumber2
            // 
            btnNumber2.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnNumber2.Location = new Point(252, 439);
            btnNumber2.Name = "btnNumber2";
            btnNumber2.Size = new Size(148, 93);
            btnNumber2.TabIndex = 4;
            btnNumber2.Text = "2";
            btnNumber2.UseVisualStyleBackColor = true;
            btnNumber2.Click += NumberButton_Click;
            // 
            // btnNumber3
            // 
            btnNumber3.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnNumber3.Location = new Point(406, 437);
            btnNumber3.Name = "btnNumber3";
            btnNumber3.Size = new Size(148, 93);
            btnNumber3.TabIndex = 5;
            btnNumber3.Text = "3";
            btnNumber3.UseVisualStyleBackColor = true;
            btnNumber3.Click += NumberButton_Click;
            // 
            // btnNumber4
            // 
            btnNumber4.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnNumber4.Location = new Point(98, 538);
            btnNumber4.Name = "btnNumber4";
            btnNumber4.Size = new Size(148, 93);
            btnNumber4.TabIndex = 6;
            btnNumber4.Text = "4";
            btnNumber4.UseVisualStyleBackColor = true;
            btnNumber4.Click += NumberButton_Click;
            // 
            // btnNumber5
            // 
            btnNumber5.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnNumber5.Location = new Point(252, 538);
            btnNumber5.Name = "btnNumber5";
            btnNumber5.Size = new Size(148, 93);
            btnNumber5.TabIndex = 7;
            btnNumber5.Text = "5";
            btnNumber5.UseVisualStyleBackColor = true;
            btnNumber5.Click += NumberButton_Click;
            // 
            // btnNumber6
            // 
            btnNumber6.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnNumber6.Location = new Point(406, 538);
            btnNumber6.Name = "btnNumber6";
            btnNumber6.Size = new Size(148, 93);
            btnNumber6.TabIndex = 8;
            btnNumber6.Text = "6";
            btnNumber6.UseVisualStyleBackColor = true;
            btnNumber6.Click += NumberButton_Click;
            // 
            // btnNumber7
            // 
            btnNumber7.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnNumber7.Location = new Point(98, 637);
            btnNumber7.Name = "btnNumber7";
            btnNumber7.Size = new Size(148, 93);
            btnNumber7.TabIndex = 9;
            btnNumber7.Text = "7";
            btnNumber7.UseVisualStyleBackColor = true;
            btnNumber7.Click += NumberButton_Click;
            // 
            // btnNumber8
            // 
            btnNumber8.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnNumber8.Location = new Point(252, 637);
            btnNumber8.Name = "btnNumber8";
            btnNumber8.Size = new Size(148, 93);
            btnNumber8.TabIndex = 10;
            btnNumber8.Text = "8";
            btnNumber8.UseVisualStyleBackColor = true;
            btnNumber8.Click += NumberButton_Click;
            // 
            // btnNumber9
            // 
            btnNumber9.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnNumber9.Location = new Point(406, 637);
            btnNumber9.Name = "btnNumber9";
            btnNumber9.Size = new Size(148, 93);
            btnNumber9.TabIndex = 11;
            btnNumber9.Text = "9";
            btnNumber9.UseVisualStyleBackColor = true;
            btnNumber9.Click += NumberButton_Click;
            // 
            // btnNumber0
            // 
            btnNumber0.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnNumber0.Location = new Point(252, 736);
            btnNumber0.Name = "btnNumber0";
            btnNumber0.Size = new Size(148, 93);
            btnNumber0.TabIndex = 12;
            btnNumber0.Text = "0";
            btnNumber0.UseVisualStyleBackColor = true;
            btnNumber0.Click += NumberButton_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnClear.Location = new Point(252, 338);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(148, 93);
            btnClear.TabIndex = 13;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnBackSpace
            // 
            btnBackSpace.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnBackSpace.Location = new Point(406, 338);
            btnBackSpace.Name = "btnBackSpace";
            btnBackSpace.Size = new Size(148, 93);
            btnBackSpace.TabIndex = 14;
            btnBackSpace.Text = "del";
            btnBackSpace.UseVisualStyleBackColor = true;
            btnBackSpace.Click += btnDel_Click;
            // 
            // btnClearEntry
            // 
            btnClearEntry.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnClearEntry.Location = new Point(98, 340);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(148, 93);
            btnClearEntry.TabIndex = 15;
            btnClearEntry.Text = "CE";
            btnClearEntry.UseVisualStyleBackColor = true;
            btnClearEntry.Click += btnCE_Click;
            // 
            // btnDivision
            // 
            btnDivision.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnDivision.Location = new Point(560, 338);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(148, 93);
            btnDivision.TabIndex = 16;
            btnDivision.Text = "÷";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += OperatorButton_Click;
            // 
            // btnMultiplication
            // 
            btnMultiplication.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnMultiplication.Location = new Point(560, 439);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.Size = new Size(148, 93);
            btnMultiplication.TabIndex = 17;
            btnMultiplication.Text = "×";
            btnMultiplication.UseVisualStyleBackColor = true;
            btnMultiplication.Click += OperatorButton_Click;
            // 
            // btnSubtraction
            // 
            btnSubtraction.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnSubtraction.Location = new Point(560, 538);
            btnSubtraction.Name = "btnSubtraction";
            btnSubtraction.Size = new Size(148, 93);
            btnSubtraction.TabIndex = 18;
            btnSubtraction.Text = "-";
            btnSubtraction.UseVisualStyleBackColor = true;
            btnSubtraction.Click += OperatorButton_Click;
            // 
            // btnAddition
            // 
            btnAddition.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnAddition.Location = new Point(560, 637);
            btnAddition.Name = "btnAddition";
            btnAddition.Size = new Size(148, 93);
            btnAddition.TabIndex = 19;
            btnAddition.Text = "+";
            btnAddition.UseVisualStyleBackColor = true;
            btnAddition.Click += OperatorButton_Click;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnEquals.Location = new Point(560, 736);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(148, 93);
            btnEquals.TabIndex = 20;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEqual_Click;
            // 
            // btnPMChange
            // 
            btnPMChange.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnPMChange.Location = new Point(98, 736);
            btnPMChange.Name = "btnPMChange";
            btnPMChange.Size = new Size(148, 93);
            btnPMChange.TabIndex = 21;
            btnPMChange.Text = "±";
            btnPMChange.UseVisualStyleBackColor = true;
            // 
            // btnPoint
            // 
            btnPoint.Font = new Font("맑은 고딕", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnPoint.Location = new Point(406, 736);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(148, 93);
            btnPoint.TabIndex = 22;
            btnPoint.Text = ".";
            btnPoint.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 966);
            Controls.Add(btnPoint);
            Controls.Add(btnPMChange);
            Controls.Add(btnEquals);
            Controls.Add(btnAddition);
            Controls.Add(btnSubtraction);
            Controls.Add(btnMultiplication);
            Controls.Add(btnDivision);
            Controls.Add(btnClearEntry);
            Controls.Add(btnBackSpace);
            Controls.Add(btnClear);
            Controls.Add(btnNumber0);
            Controls.Add(btnNumber9);
            Controls.Add(btnNumber8);
            Controls.Add(btnNumber7);
            Controls.Add(btnNumber6);
            Controls.Add(btnNumber5);
            Controls.Add(btnNumber4);
            Controls.Add(btnNumber3);
            Controls.Add(btnNumber2);
            Controls.Add(btnNumber1);
            Controls.Add(txtResult);
            Controls.Add(txtCalculation);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private TextBox txtCalculation;
        private TextBox txtResult;
        private Button btnNumber1;
        private Button btnNumber2;
        private Button btnNumber3;
        private Button btnNumber4;
        private Button btnNumber5;
        private Button btnNumber6;
        private Button btnNumber7;
        private Button btnNumber8;
        private Button btnNumber9;
        private Button btnNumber0;
        private Button btnClear;
        private Button btnBackSpace;
        private Button btnClearEntry;
        private Button btnDivision;
        private Button btnMultiplication;
        private Button btnSubtraction;
        private Button btnAddition;
        private Button btnEquals;
        private Button btnPMChange;
        private Button btnPoint;
    }
}

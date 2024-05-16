namespace fishing
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
            label1 = new Label();
            upgrade = new Button();
            rock = new Label();
            weight = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("궁서", 56F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.Location = new Point(200, 5);
            label1.Name = "label1";
            label1.Size = new Size(590, 120);
            label1.TabIndex = 0;
            label1.Text = "돌 강화하기";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // upgrade
            // 
            upgrade.Font = new Font("바탕", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            upgrade.Location = new Point(350, 400);
            upgrade.Name = "upgrade";
            upgrade.Size = new Size(300, 100);
            upgrade.TabIndex = 1;
            upgrade.Text = "강화하기";
            upgrade.UseVisualStyleBackColor = true;
            upgrade.Click += upgradeButtonClicked;
            // 
            // rock
            // 
            rock.Font = new Font("궁서", 36F, FontStyle.Bold);
            rock.Location = new Point(3, 125);
            rock.Name = "rock";
            rock.Size = new Size(985, 267);
            rock.TabIndex = 2;
            rock.Text = "0강 일반 돌";
            rock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // weight
            // 
            weight.Font = new Font("굴림", 32F);
            weight.Location = new Point(400, 125);
            weight.Name = "weight";
            weight.Size = new Size(200, 75);
            weight.TabIndex = 3;
            weight.Text = "98%";
            weight.TextAlign = ContentAlignment.MiddleCenter;
            weight.Click += weight_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 561);
            Controls.Add(weight);
            Controls.Add(rock);
            Controls.Add(upgrade);
            Controls.Add(label1);
            Font = new Font("돋움", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "돌 강화하기";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button upgrade;
        private Label rock;
        private Label weight;
    }
}

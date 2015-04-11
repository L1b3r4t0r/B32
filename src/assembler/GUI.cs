using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace B32.src.assembler
{
    public partial class GUI : Form
    {
        private string SourceProgram;
        private System.Collections.Hashtable LabelTable;
        private int CurrentNdx;
        private ushort AsLength;
        private bool IsEnd;
        private ushort ExecutionAddress;
        private enum Registers
        {
            Unknown = 0,
            A = 4,
            B = 2,
            D = 1,
            X = 16,
            Y = 8
        }
        public GUI()
        {
            LabelTable = new System.Collections.Hashtable(50); CurrentNdx = 0; AsLength = 0; ExecutionAddress = 0; IsEnd = false; SourceProgram = ""; txtOrigin.Text = "1000";   
            InitializeComponent();
        }

        private void btnSourceBrowse_Click(object sender, EventArgs e)
        {
            this.fdSourceFile.ShowDialog();
            this.txtSourceFileName.Text = fdSourceFile.FileName;
        }

        private void btnOutputBrowse_Click(object sender, EventArgs e)
        {
            this.fdDestinationFile.ShowDialog();
            this.txtOutputFileName.Text = fdDestinationFile.FileName;
        }

        private void btnAssemble_Click(object sender, EventArgs e)
        {
            AsLength = Convert.ToUInt16(this.txtOrigin.Text, 16);
            System.IO.BinaryWriter output;
            System.IO.TextReader input;
            System.IO.FileStream fs = new
            System.IO.FileStream(this.txtOutputFileName.Text, System.IO.FileMode.Create);
            output = new System.IO.BinaryWriter(fs);
            input = System.IO.File.OpenText(this.txtSourceFileName.Text);
            SourceProgram = input.ReadToEnd();
            input.Close();
            output.Write('B');
            output.Write('3');
            output.Write('2');
            output.Write(Convert.ToUInt16(this.txtOrigin.Text, 16));
            output.Write((ushort)0);
            Parse(output);
            output.Seek(5, System.IO.SeekOrigin.Begin);
            output.Write(ExecutionAddress);
            output.Close();
            fs.Close();
            MessageBox.Show("Done!"); 
        }

        private void Parse(System.IO.BinaryWriter OutputFile)
        {
            CurrentNdx = 0;
            while (IsEnd == false)
                LabelScan(OutputFile, true);
            IsEnd = false;
            CurrentNdx = 0;
            AsLength = Convert.ToUInt16(this.txtOrigin.Text, 16);

            while (IsEnd == false)
                LabelScan(OutputFile, false);
        }
        private void LabelScan(System.IO.BinaryWriter OutputFile, bool IsLabelScan)
        {
            if (char.IsLetter(SourceProgram[CurrentNdx]))
            {
                // Must be a label
                if (IsLabelScan) LabelTable.Add(GetLabelName(), AsLength);
                while (SourceProgram[CurrentNdx] != '\n')
                    CurrentNdx++;
                CurrentNdx++;
                return;
            }
            EatWhiteSpaces();
            ReadMneumonic(OutputFile, IsLabelScan);
        }
        private void ReadMneumonic(System.IO.BinaryWriter OutputFile, bool IsLabelScan)
        {
            string Mneumonic = "";
            while (!(char.IsWhiteSpace(SourceProgram[CurrentNdx])))
            {
                Mneumonic = Mneumonic + SourceProgram[CurrentNdx];
                CurrentNdx++;
            }

            if (Mneumonic.ToUpper() == "LDX") InterpretLDX(OutputFile, IsLabelScan);
            if (Mneumonic.ToUpper() == "LDA") InterpretLDA(OutputFile, IsLabelScan);
            if (Mneumonic.ToUpper() == "STA") InterpretSTA(OutputFile, IsLabelScan);
            if (Mneumonic.ToUpper() == "END")
            {
                IsEnd = true;
                DoEnd(OutputFile, IsLabelScan);
                EatWhiteSpaces();
                ExecutionAddress = (ushort)LabelTable[(GetLabelName())]; return;
            }
            while (SourceProgram[CurrentNdx] != '\n')
            {
                CurrentNdx++;
            }
            CurrentNdx++;
        }
    }
}

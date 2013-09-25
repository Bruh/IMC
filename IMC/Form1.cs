using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLim_Click(object sender, EventArgs e)
        {
            textBoxPeso.Clear();
            textBoxAltura.Clear();
        }

        private void buttonCal_Click(object sender, EventArgs e)
        {
            double IMC, PESO, ALTURA;
            ALTURA = Convert.ToDouble(Convert.ToString(textBoxAltura.Text));
            PESO = Convert.ToDouble(Convert.ToString(textBoxPeso.Text));
            IMC = PESO / (ALTURA * ALTURA);

            if (IMC <= 18.5)
            {
                MessageBox.Show( "Com IMC "+ IMC +".\n Nesse ponto, o corpo magro deixa de ser saudável e o organismo fica mais vulnerável a infecções.Se o baixo peso persistir,  mesmo com a alimentação normal, procure ajuda médica; a dififuldade para engordar pode ser sintoma de alguma doença insidiosa, como o diabetes.", "Seu resultado foi BAIXO PESO");    
            }

            if (IMC >= 18.5 && IMC <= 24.9)
            {
                MessageBox.Show("Com IMC " + IMC + ".\n Seu peso está adequado à altura. É importante manter a educação alimentar e a atividade física. Fique atento seu valor esteja perto dos limites para os estágios de BAIXO PESO ou SOBREPESO.", "Seu resultado foi PESO NORMAL ");
            }

            if (IMC >= 24.9 && IMC <= 29.9)
            {
                MessageBox.Show("Com IMC " + IMC + ".\n Está faixa indica que você está com predisposição à obesidade; dependendo do seu histórico familiar e pessoal, pode haver um quadro de pré-diabetes e hipertensão. Procure orientação médica para evitar o próximo estágio, OBESIDADE 1. Quanto mais quilos extras, maior a dificuldade para emagrecer.", "Seu resultado foi SOBREPESO");
            }

            if (IMC >= 29.9 && IMC <= 34.9)
            {
                MessageBox.Show("Com IMC " + IMC + ".\n O risco de desenvolver diabetes,para quem está nesta faixa de peso, é de 20%, e o de hipertensão ultrapassa 25%,Há risco maior de outras doenças cardiovasculares, articulares, distúrbios, psiquiátricos, apneia do sono e até certos tipos de cancêr.", "Seu resultado foi OBESIDADE GRAU 1 ");
            }

            if (IMC >= 34.9 && IMC <= 39.9)
            {
                MessageBox.Show("Com IMC " + IMC + ".\n O risco de desenvolver diabetes chega a 40% e a chance de surgirem doenças associadas à obsidade, como reumatismos, cancêr, apneia do sono, hipertensão e outros problemas cardiovasculares pode chegar a 50%.Procure orientação médica.", "Seu resultado foi OBSIDADE GRAU 2");
            }

            if (IMC >= 39.9 && IMC <= 40)
            {
                MessageBox.Show("Com IMC " + IMC + ".\n O risco de desenvolver doenças associados ao excesso de peso, como diabetes, reumatismo, cancêr, apneia do sono, hipertensão e outros problemas cardiovasculares chega a até 90%. Neste estágio, a cirurgia de redução do estômago pode ser indicada. Procure orinetação médica imediatamente.", "Seu resultado foi OBSIDADE GRAU 3");
            }

            
        }
    }
}

using System.DirectoryServices.ActiveDirectory;
using val_type = double;

namespace ExerciceRecapTP2
{
    public partial class Form1 : Form
    {

        public val_type val1 = 0;
        public val_type val2 = 0;
        public int decim = -1;
        public int selectedVal = 1;
        public char op = ' ';
        public val_type MEMORY = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private String repeatStr(String str, int n)
        {
            if (n <= 0) return "";
            if (n == 1) return str;

            return str + repeatStr(str, n - 1);
        }


        private String parseVal(val_type valRaw)
        {
            float val = (float) valRaw;
            return val.ToString();
        }


        // Afficher les opérations et les valeurs en "FLOAT" pour éviter
        // les erreurs de virgules comme : 2.3 = 2.30000000004
        private void updateAffichage()
        {
            if (selectedVal == 1)
            {
                txtAffichage.Text = parseVal(val1);
            }
            else
            {
                txtAffichage.Text = "  "+ parseVal(val1) + "\r\n" + op + " " + parseVal(val2);
            }
        }

        // Ajoute un chiffre à la suite, sans utiliser de chaines de
        // caractères
        private void appendNumber(int n)
        {
            val_type val = (selectedVal == 1 ? val1 : val2);
            if (decim == -1)
                val = val * 10 + (val < 0 ? -n : n);
            else
            {
                val = val + (val_type) Math.Pow(10, -(decim + 1)) * (val < 0 ? -n : n);
                decim++;
            }

            if (selectedVal == 1)
                val1 = val;
            else
                val2 = val;

            updateAffichage();
        }

        // Ajoute un opérateur, et si l'opérateur
        // a déjà été ajouté une fois, effectue l'ancien
        // calcul avant de passer au nouveau
        private void operation(char c)
        {
            bool cont = true;
            if (selectedVal == 2)
            {
                cont = calculate();
            }

            if (cont)
            {
                op = c;
                updateAffichage();
                selectedVal = 2;
            }
        }

        // Execute une opération comme les calculatrices classiques
        private bool calculate()
        {
            if (selectedVal == 2)
            {
                if (op == '+')
                {
                    val1 = val1 + val2;
                }
                else if (op == '-')
                {
                    val1 = val1 - val2;
                }
                else if (op == '×')
                {
                    val1 = val1 * val2;
                }
                else if (op == '÷')
                {
                    if (val2 == 0)
                    {
                        MessageBox.Show("Division par 0 impossible");
                        return false;
                    }
                    val1 = val1 / val2;
                }
            }
            val2 = 0;
            selectedVal = 2;
            txtAffichage.Text = "= " + parseVal(val1);
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // ========== BOUTONS 0-9 ==========
        private void buttonN0_Click(object sender, EventArgs e)
        {
            appendNumber(0);
        }

        private void buttonN1_Click(object sender, EventArgs e)
        {
            appendNumber(1);
        }

        private void buttonN2_Click(object sender, EventArgs e)
        {
            appendNumber(2);
        }

        private void buttonN3_Click(object sender, EventArgs e)
        {
            appendNumber(3);
        }

        private void buttonN4_Click(object sender, EventArgs e)
        {
            appendNumber(4);
        }

        private void buttonN5_Click(object sender, EventArgs e)
        {
            appendNumber(5);
        }

        private void buttonN6_Click(object sender, EventArgs e)
        {
            appendNumber(6);
        }

        private void buttonN7_Click(object sender, EventArgs e)
        {
            appendNumber(7);
        }

        private void buttonN8_Click(object sender, EventArgs e)
        {
            appendNumber(8);
        }

        private void buttonN9_Click(object sender, EventArgs e)
        {
            appendNumber(9);
        }

        // Opposer la valeur
        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            if (selectedVal == 1)
                val1 = -val1;
            else
                val2 = -val2;

            updateAffichage();
        }

        //Ajouter une décimale
        private void buttonPoint_Click(object sender, EventArgs e)
        {
            // Ici, on ajoute pas directement de "." ou ","
            // Mais on indique que la valeur est décimale et plus entière
            if (decim == -1) decim = 0;
            updateAffichage();
        }

        private void buttonEgal_Click(object sender, EventArgs e)
        {
            calculate();
            selectedVal = 1;
        }

        // ========== OPERATIONS ==========
        private void buttonAddition_Click(object sender, EventArgs e)
        {
            operation('+');
        }

        private void buttonSoustraction_Click(object sender, EventArgs e)
        {
            operation('-');
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            operation('×');
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            operation('÷');
        }

        // EFFACER un chiffre avec le même principe que l'ajout
        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            val_type val = (selectedVal == 1 ? val1 : val2);
            if (decim == -1)
            {
                (val,_) = Math.DivRem((int) val, 10);
            } else
            {
                val = val * (val_type)Math.Pow(10, decim - 1);
                val = Math.Floor(val);
                val = val * (val_type)Math.Pow(10, -(decim - 1));
                decim -= 1;
            }
            if(selectedVal == 1)
            {
                val1 = val;
            } else
            {
                val2 = val;
            }
            updateAffichage();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            val1 = 0;
            val2 = 0;
            decim = -1;
            selectedVal = 1;
            updateAffichage();
        }

        private void buttonPercent_Click(object sender, EventArgs e)
        {
            if (selectedVal == 1)
            {
                val1 = val1 / 100;
            }
            else
            {
                val2 = val2 / 100;
            }
        }

        private void buttonMPlus_Click(object sender, EventArgs e)
        {
            MEMORY += (selectedVal == 1 ? val1 : val2);
        }

        private void buttonMMoins_Click(object sender, EventArgs e)
        {
            MEMORY -= (selectedVal == 1 ? val1 : val2);
        }

        private void buttonMClear_Click(object sender, EventArgs e)
        {
            MEMORY = 0;
        }

        private void buttonMRecall_Click(object sender, EventArgs e)
        {
            if(selectedVal == 1)
            {
                val1 = MEMORY;
            } else
            {
                val2 = MEMORY;
            }

            updateAffichage();
        }
    }
}

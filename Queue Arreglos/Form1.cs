using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Queue_Arreglos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Queue_Array queue = new Queue_Array();

        private void BtnEnqueue_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32( TxtNumberAdd.Text);
            if (!queue.IsFull()) 
            {
                queue.Enqueue(number); // Encola el número.
                TxtNumberAdd.Clear(); // Limpia el cuadro de texto.
                LisboxQueue.Items.Add(number.ToString()); // Agrega el número a la ListBox.
            }
            else
            {
                MessageBox.Show("La cola está llena, no se puede agregar más elementos.");
            }
        }

        private void BtnDequeue_Click(object sender, EventArgs e)
        {
            if (!queue.IsEmpty())
            {
                MessageBox.Show(queue.Dequeue());
                LisboxQueue.Items.RemoveAt(0); // Remueve el primer elemento de la ListView
                return;
            }
            MessageBox.Show("No hay datos para sacar");
        }

        private void BtnPeek_Click(object sender, EventArgs e)
        {
            if (!(queue.IsEmpty()))
            {
                MessageBox.Show(queue.Peek());
                return;
            }

            MessageBox.Show("No existen datos por mostrar");
        }


        private void BtnSizeIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("en la cola normal hay " + queue.Size().ToString() + " espacios ocupados en la cola estatica de 5");
        }
    }
}

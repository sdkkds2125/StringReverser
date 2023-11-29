namespace StringReverser
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
             loadJokes();
        }

        private void loadJokes()
        {
            string fullText;
            Console.WriteLine("Current Directory: " + Directory.GetCurrentDirectory());
            // StreamReader sr = new StreamReader("..\\jokes.txt");
            //Read the first line of text
            //string? line = sr.ReadLine();
            try
            {
                
                fullText = File.ReadAllText("C:\\Users\\shlom\\source\\repos\\StringReverser\\jokes.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            //Continue to read until you reach end of file
            //while (line != null)
            //{
            //    fullText += line + "\n";
            //    //Read the next line
            //    line = sr.ReadLine();
            //}
            //close the file
            //sr.Close();
            // Console.ReadLine();
            richTextBox1.Text = fullText;
        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
            string inputText = InputTextBox.Text;
            string reversedText = ReverseWords(inputText);
            OutputTextBox.Text = reversedText;
        }

        private string ReverseWords(string input)
        {
            Stack<char> stack = new Stack<char>();
            List<char> resultChars = new List<char>();

            foreach (char c in input)
            {
                if (c != ' ' && c != '\n')
                {
                    stack.Push(c);
                }
                else if (c == ' ')
                {
                    while (stack.Count > 0)
                    {
                        resultChars.Add(stack.Pop());
                    }
                    resultChars.Add(' ');
                }
                else if (c == '\n')
                {
                    while (stack.Count > 0)
                    {
                        resultChars.Add(stack.Pop());
                    }
                    resultChars.Add('\n');
                }
            }

            while (stack.Count > 0)
            {
                resultChars.Add(stack.Pop());
            }

            return new string(resultChars.ToArray());
        }

        private void Reverse_jokes_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ReverseWords(richTextBox1.Text);
        }

        private void Reverse_input_Click(object sender, EventArgs e)
        {
            ReverseButton_Click(sender, e);
        }
    }
}
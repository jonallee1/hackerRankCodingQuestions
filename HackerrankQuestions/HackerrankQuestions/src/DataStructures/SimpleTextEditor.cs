using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankQuestions.src.DataStructures
{
    class SimpleTextEditor
    {
        private string str;
        private Stack<Tuple<int, string>> commands;
        Tuple<int, string> temp;
        public SimpleTextEditor()
        {
            this.str = "";

            commands = new Stack<Tuple<int, string>>();
            runprogram();
        }

        public void runprogram()
        {
            int numqueue = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numqueue; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                if (tokens.Length == 2)
                {
                    int a = int.Parse(tokens[0]);
                    if (a == 1)
                    {

                        append(tokens[1]);

                    }
                    else if (a == 2)
                    {

                        delete(Convert.ToInt32(tokens[1]));
                    }
                    else
                    {
                        print(Convert.ToInt32(tokens[1]));
                    }

                }
                else
                {
                    undo();

                }


            }
            int numqueue1 = Convert.ToInt32(Console.ReadLine());
        }

        public void append(string w)
        {
            

            str = str + w;
            Console.WriteLine(str);
            temp = new Tuple<int, string>(2, w);
         
            commands.Push(temp);

        }

        public void delete(int n)
        {
            Console.WriteLine(str);
            string tempstr = str.Substring(str.Length - n );
            
            temp = new Tuple<int, string>(1, tempstr);
            
            commands.Push(temp);
            str = str.Substring(0, str.Length - n);
            Console.WriteLine(str);
        }

        public void print(int k)
        {
            Console.WriteLine(str[k - 1]);
        }

        public void appendundo(string w)
        {
            str = str + w;
          
        }
        public void undodelete(int n) {
            str = str.Substring(0, str.Length - n);
        }

        public void undo() {
           
            Tuple<int, string> temp = commands.Pop();
           
            if (temp.Item1 == 1)
            {
                appendundo(temp.Item2);
            }
            else
            {
                undodelete(temp.Item2.Length);
            }

        }

    }

   



}

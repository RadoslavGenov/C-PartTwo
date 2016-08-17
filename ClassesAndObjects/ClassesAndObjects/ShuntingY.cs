using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class ShuntingY
    {
        //TODO: algebraic functions
        public static int leftAssociative = 1;
        public static int rightAssociative = 0;
        public static Dictionary<string, int> operatorAssociativity = new Dictionary<string, int>()
        {
            { "/", leftAssociative},
            { "*", leftAssociative},
            { "-", leftAssociative},
            { "+", leftAssociative},
            { "^", rightAssociative}
        };

        static int Precedence(string token)
        {
            int precedece = 0;
            switch (token)
            {
                case "^":
                    precedece = 4;
                    break;
                case "*":
                    precedece = 3;
                    break;
                case "/":
                    precedece = 3;
                    break;
                case "+":
                    precedece = 2;
                    break;
                case "-":
                    precedece = 2;
                    break;
                default:
                    return 1;
            }
            return precedece;
        }
        static bool IsOperator(string token)
        {
            return token == "/" || token == "*" || token == "^" || token == "-" || token == "+";
        }
        static Queue<string> ShuntingYard(string[] tokens)
        {
            Stack<string> operators = new Stack<string>();
            Queue<string> output = new Queue<string>();
            foreach (string token in tokens)
            {
                int number;
                if (int.TryParse(token, out number))
                {
                    output.Enqueue(number.ToString());
                }
                else if (IsOperator(token))
                {
                    while (operators.Count() != 0 &&
                        ((operatorAssociativity[token] == 0 && Precedence(token) <= Precedence(operators.Peek())) ||
                        (operatorAssociativity[token] == 1 && Precedence(token) <= Precedence(operators.Peek()))))
                    {
                        output.Enqueue(operators.Pop());
                    }
                    operators.Push(token);
                }
                else if (token == "(")
                {
                    operators.Push(token);
                }
                else if (token == ")")
                {
                    while (operators.Peek() != "(")
                    {
                        output.Enqueue(operators.Pop());
                    }
                    operators.Pop();
                }
            }
            while (operators.Count != 0)
            {
                output.Enqueue(operators.Pop());
            }
            return output;
        }
        static double EvaluatedReversePolishNotation(Queue<string> polishNotation)
        {
            Stack<string> value = new Stack<string>();

            double result = 0;
            while (polishNotation.Count != 0)
            {
                double number;
                double first;
                double second;
                if (double.TryParse(polishNotation.Peek(), out number))
                {
                    value.Push(number.ToString());
                    polishNotation.Dequeue();
                }
                else
                {
                    switch (polishNotation.Dequeue())
                    {
                        case "^":
                            first = Convert.ToDouble(value.Pop());
                            second = Convert.ToDouble(value.Pop());
                            result = Math.Pow(second, first);
                            value.Push(result.ToString());
                            break;
                        case "*":
                            first = Convert.ToDouble(value.Pop());
                            second = Convert.ToDouble(value.Pop());
                            result = first * second;
                            value.Push(result.ToString());
                            break;
                        case "/":
                            first = Convert.ToDouble(value.Pop());
                            second = Convert.ToDouble(value.Pop());
                            result = second / first;
                            value.Push(result.ToString());
                            break;
                        case "+":
                            first = Convert.ToDouble(value.Pop());
                            second = Convert.ToDouble(value.Pop());
                            result = first + second;
                            value.Push(result.ToString());
                            break;
                        case "-":
                            first = Convert.ToDouble(value.Pop());
                            second = Convert.ToDouble(value.Pop());
                            result = second - first;
                            value.Push(result.ToString());
                            break;
                        default:
                            break;
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an arithmetical expression, each token seperated by a space: ");
            string expression = Console.ReadLine();
            string[] tokens = expression.Split(' ');
            Queue<string> PolishNotation = ShuntingYard(tokens);
            Console.WriteLine();
            Console.WriteLine("Arithmetic Expression in Reverse Polish Notation: ");
            foreach (var item in PolishNotation)
            {
                Console.Write("{0} ", item);
            }
            double result = EvaluatedReversePolishNotation(PolishNotation);
            Console.WriteLine("\n");
            Console.WriteLine("Evaluated Expression: \n{0}\n", result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace task3
{
    class Company
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (char.IsUpper(value[0]))
                {
                    foreach (char item in value)
                    {
                        if (!char.IsDigit(item) && !char.IsLetter(item) && !char.IsWhiteSpace(item))
                        {
                           
                        }
                    }
                }
                
            }
        }
        public int Limit { get; set; }
        private Employe[] _employes;

        public Company()
        {
            _employes = new Employe[0];
        }

        internal void AddEmoployee(Employe employe1)
        {
            throw new NotImplementedException();
        }
    }
            }
            
        
    

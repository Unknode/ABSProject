using AulasUdemy2.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace AulasUdemy2.Entities {
    class Worker {

        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }

        public List<Contract> Contracts { get; set; } = new List<Contract>(); // Essa lista é para os contratos que cada trabalhador terá. Já instanciada no momento da criação do objeto Worker

        public Worker() { }
        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament) {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public string AddContract(Contract contract) { //aqui ele adiciona contratos numa lista de contracts
            //implementei uma logica para verificar se um ID informado já existe dentro da lista de contracts.
            bool verify = false;

            if (Contracts.Count != 0) { //verifica se a lista não está vazia

                foreach (Contract cont in Contracts) {//percorre a lista checando se o numero do ID que entrou já existe dentro da lista

                    if (contract.ID != cont.ID) {
                        verify = false;
                    }

                    else {
                        verify = true;
                    }
                }

            }
            if (verify == false) {

                Contracts.Add(contract);
            }
            else {
                Console.WriteLine("ID already exists");
            }


            return " ";
        }

        public string RemoveContract(int id) { //metodo para remoção de um contrato, se baseando no ID informado.
            bool verify = false;

            foreach (Contract contra in Contracts) {
                if (contra.ID == id) {
                    verify = true;
                }

            }

            if (verify) {
                Contract cnt = Contracts.Find(x => x.ID == id);
                Contracts.Remove(cnt);
                return "";
            }

            else {
                return "The Contract ID is incorrect. Please enter the right one";
            }

        }


        public double InCome(int month, int year) { //esse metodo retorna o valor feito no mes/ano informado por parametros.

            double sum = BaseSalary;
            foreach (Contract cont in Contracts) {//o for vai percorrer a lista

                if (cont.Date.Year == year && cont.Date.Month == month) {// aqui será verificado se o Mes e ano passados por parametro, batem com alguma data do contrato
                    sum += cont.TotalValue();
                }
            }
            return sum;
        }

    }
}

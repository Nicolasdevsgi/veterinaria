using Sgi.Veterinaria.Domain.Core.Entidades;
using System;

namespace Sgi.Veterinaria.Domain.Animais
{
    public class Animal : EntidadeBasica
    {
        public Animal(
            DateTime dataNascimento, 
            string raca, 
            string qualAnimal, 
            decimal pesoKg, 
            bool alergicoAlgumMedicamento, 
            string medicamentoAlergico, 
            bool algumProblemaDeSaude, 
            string qualProblema)
        {
            DataNascimento = dataNascimento;
            Raca = raca;
            QualAnimal = qualAnimal;
            PesoKg = pesoKg;
            AlergicoAlgumMedicamento = alergicoAlgumMedicamento;
            MedicamentoAlergico = medicamentoAlergico;
            AlgumProblemaDeSaude = algumProblemaDeSaude;
            QualProblema = qualProblema;
        }

        public DateTime DataNascimento { get; private set; }
        public string Raca { get; private set; }
        public string QualAnimal { get; private set; }
        public decimal PesoKg { get; private set; }
        public bool AlergicoAlgumMedicamento { get; private set; }
        public string MedicamentoAlergico { get; private set; }
        public bool AlgumProblemaDeSaude { get; private set; }
        public string QualProblema { get; private set; }
    }
}

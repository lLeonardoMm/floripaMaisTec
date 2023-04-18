using System;

namespace SystemAvançadoCB.Classes
{
    public class Cliente
    {
        public string Nome { get; private set; }
        public DateTime Nascimento { get; private set; }
        public string Profissao { get; private set; }
        public TiposEnumEstadoCivil EstadoCivil { get; private set; }
        public TipoEnumTipoPessoa TipoPessoa { get; private set; }

        public Cliente(string nome,string profissao, TiposEnumEstadoCivil estadoCivil, TipoEnumTipoPessoa tipoPessoa, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
            Profissao = profissao;
            EstadoCivil = estadoCivil;
            TipoPessoa = tipoPessoa;
        }
    }
}

using System;
using System.Collections.Generic;

public class Funcionario
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public DateTime DateTime { get; set; }
    public string Cpf { get; set; }
    public string Rg { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public string Estado_civil { get; set; }
    public string Funcao { get; set; }
    public double Salario { get; set; }

    public Funcionario() {}

    public Funcionario(string nome, DateTime data_nas, string cpf, string rg, string email, string telefone, string estado_civil, string funcao, double salario)
    {
        Nome = nome;
        DateTime = data_nas;
        Cpf = cpf;
        Rg = rg;
        Email = email;
        Telefone = telefone;
        Estado_civil = estado_civil;
        Funcao = funcao;
        Salario = salario;
      
    }
    
}


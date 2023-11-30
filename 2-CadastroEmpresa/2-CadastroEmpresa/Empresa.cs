using System;

public class Empresa
{
    public int Id { get; set; }
    public string RazaoSocial { get; set; }
    public string NomeFantasia { get; set; }
    public string RegimeTributario { get; set; }
    public string PorteEmpresa { get; set; }
    public string Tipo { get; set; }
    public string NaturezaJuridica{ get; set; }
    public string SituacaoCadastral { get; set; }
    public string Telefone { get; set; }
    public double CapitalSocial { get; set; }
    public DateTime DataInicio { get; set; }    
    public string  Cnpj {  get; set; }  
    public string NomeProprietario { get; set; }
    public string CpfProprietario { get; set; }

    public Empresa() { }

    public Empresa(string razaosocial, string nomefantasia, string regimetrib, string PorteEmpresa, string Tipo, string NaturezaJur, string situacaocada, string telefone, double capitalsoc, DateTime datainicio,string cnpj, string nomepro, string cpfpro)
    {
        this.RazaoSocial = razaosocial;
        this.NomeFantasia = nomefantasia;
        this.RegimeTributario = regimetrib;
        this.PorteEmpresa = PorteEmpresa;
        this.Tipo = Tipo;
        this.NaturezaJuridica = NaturezaJur;
        this.SituacaoCadastral = situacaocada;
        this.Telefone = telefone;
        this.CapitalSocial = capitalsoc;
        this.DataInicio = datainicio;
        this.Cnpj = cnpj;
        this.NomeProprietario = nomepro;
        this.CpfProprietario = cpfpro;


    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
  public class Cliente
  {
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string Profissao { get; set; }

    public override bool Equals(object obj)
    {
      //Cliente cliente = (Cliente)obj; se os obj sao diferente da excepetion

      /*Cliente cliente = obj as Cliente; // tenta converter
      
      if (cliente == null)
      {
        return false;
      }*/

      if (!(obj is Cliente cliente))
      {
        return false;
      }

      return Nome == cliente.Nome &&
              CPF == cliente.CPF &&
              Profissao == cliente.Profissao;
    }
  }
}

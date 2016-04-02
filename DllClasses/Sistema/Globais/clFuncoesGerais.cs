namespace DllClasses.Net.Sistema.Globais
{
    public class clFuncoesGerais
    {
        public enum Operacao
        {
            Inclusao,
            Alteracao
        }

        public string remove_acentos(string str)
        {
            string C_acentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇçºª";
            string S_acentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCcoa";

            for (int i = 0; i < C_acentos.Length; i++)
                str = str.Replace(C_acentos[i].ToString(), S_acentos[i].ToString()).Trim();
            return str;
        }

        public string remove_alfa(string alfa)
        {
            string C_alfa = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇçº!@#$%¨&*()_+={[ª?//°;:.>,<|\\§-}]";
            string S_alfa = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCco                                 ";

            for (int i = 0; i < C_alfa.Length; i++)
                alfa = alfa.Replace(C_alfa[i].ToString(), S_alfa[i].ToString()).Trim();
            alfa = alfa.Replace(" ", "");
            return alfa;
        }
    }
}

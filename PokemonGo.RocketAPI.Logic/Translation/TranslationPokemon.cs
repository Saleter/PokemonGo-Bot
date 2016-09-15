using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace PokemonGo.RocketAPI.Logic.Translation
{
    public class TranslationPokemon
    {
        private static Dictionary<String, String> lookup = null;

        public static String getString(String messageKey)
        {
            if (lookup == null)
                TranslationPokemonS();

            if (lookup.ContainsKey(messageKey))
            {
                return lookup[messageKey];
            }
            return messageKey;
        }

        public static void TranslationPokemonS()
        {
            if (System.IO.File.Exists("TranslationsPokemon/pokemon.json"))
            {
                    lookup = JsonConvert.DeserializeObject<Dictionary<String, String>>(System.IO.File.ReadAllText("translationspokemon/pokemon.json", Encoding.UTF8));
            }
            else
            {
                lookup = new Dictionary<string, string>();
            }
        }
    }
}

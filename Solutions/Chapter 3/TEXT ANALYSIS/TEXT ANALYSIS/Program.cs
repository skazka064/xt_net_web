using System;
using System.Collections.Generic;
using System.Linq;


namespace TEXT_ANALYSIS
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = "with with with with with with with with with with with with with with with with with " +
                "with with with with with with with with with with with with with with with with with with with with " +
                "with with with with with with with with with with with with with with with with with with with with " +
                "with with with with with with with with with with with with with with with with with with with with " +
                "with with with with with with with with with with with with with with with with with with with with " +
                "with with with with with with with with with with with with with with with with with with with with " +
                "with with with   Disco is an abbreviation of the French word discotheque - disco. " +
                "This can be translated as disk storage. And so called nightlife, where the music recorded on the " +
                "plates (not live, unlike ordinary clubs) sounded. Then the word disco began to be called a " +
                "musical style with a rhythm of 100-120 beats per minute. Another important element of the disco " +
                "is the shiny, eye-cutting clothing, all kinds of multi-colored bulbs, mirror balls, neon flashes, long turn-down " +
                "collars, tall hairstyles - in general, emphasized brightness and chic in everything." +
                "A jukebox can be considered the progenitor of a disco -a gramophone - machine charged with two or" +
                " three dozen records, which are optionally played when a small coin is lowered into the slot. At the turn" +
                " of the 1930s and 1940s, such machines were installed throughout America(and after World War II and in " +
                "Western European countries) in cheap bars and cafes, which were visited mainly by young people. " +
                "They had their own audience, their own repertoire, and even their own stars; it was jukeboxes that were" +
                " the main channel for the distribution of music such as rhythm and blues, and later - soul." +
                "The development of recording technology provided an absolutely incredible upsurge in the gramophone" +
                " industry: long - playing discs, portable players began to be produced, and music recordings became " +
                "very popular.Special music radio stations appeared, the main tasks of which were advertising and " +
                "promotion of new records and artists on the music market.With the advent of rock'n'roll, the radio" +
                " audience expanded unbelievably at the expense of millions of teenagers, who formed an exceptionally " +
                "wide and capacious market for the sale of records.Three whales of the gramophone" +
                " industry - ARC - Victor(RCA - Victor), Columbia, Warner Brothers - established a virtual " +
                "monopoly on the release and distribution of records of popular music; they controlled the air, organized " +
                "concert tours, supported fan clubs, influential magazines and criticism.   The first discos, " +
                "in the modern sense of the word, appeared in New York, and they mostly sounded soul and funk " +
                "records with a hard rhythmic base. The main distinguishing feature of the disco is its uniform rhythm, " +
                "often emphasized by the kicks.The classic speed is recognized with a frequency of 120" +
                " beats per minute(which is almost twice the normal human pulse). A continuous bass line is characteristic," +
                " in the arrangements string and wind solos are used.The structure of songs often consists of several " +
                "blocks (with a change in the pattern of bass, melody, tonality, etc.), which does not allow long songs to " +
                "bore the listener." +
                "The most successful numbers fell on radio stations, which increased record sales." +
                " Record companies and producers began to focus on recording special music for discos, " +
                "and very soon disco music went beyond the walls of clubs and gained widespread recognition and" +
                " popularity.In the second half of the 70s, the western world was overwhelmed by another dance epidemic," +
                " as has happened more than once in the past, but with one interesting difference.Until now, all decent social " +
                "dances, not to mention grand ballroom gatherings and metropolitan dance halls, have been sought to be " +
                "arranged with even a modest, but still live orchestra or small ensemble, at the very least being content " +
                "with one pianist, and only with the inability to get one resorted to a gramophone, radio or the already " +
                "mentioned jukebox. Now this custom has been replaced by the exact opposite: the highest chic is to" +
                " dance in specially equipped discos to recorded music with a disc jockey (DJ) as the operator of " +
                "sound-reproducing equipment and the manager of the ball.Disco albums were not long, but the songs" +
                " recorded on them became much longer - an average of 5-6 minutes, at the same time special 12-inch " +
                "singles were released containing long versions of songs (8-12 minutes) for djs.Having in stock a wide " +
                "range of records, DJ each time makes his own mix of them, combining the numbers taking into account" +
                " the composition, probable tastes and even the mood of the audience gathered in front of him, and " +
                "sometimes a specially selected audience(the owners of some discos every night make selection and" +
                " face-control of the lucky from long lines facing their doors).Disco is a child of a big city, its cradle is" +
                " huge recording studios with state-of-the-art equipment worth hundreds of thousands of dollars.Disco" +
                " music takes its first steps in the most fashionable discos, where it receives noisy recognition or fails," +
                " and only if successful at a metropolitan party, it spreads with lightning speed in the province. " +
                "In other words, it is a highly centralized branch of the music industry, with a technical and financial " +
                "organization, led by professionals - producers and managers, along with full-time composers of melodies and lyrics. " +
                "From music production, more and more novelty and originality are required.".ToLower();

            new Analitic(text);
        }
    }

    class Analitic
    {
        private string _text;
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        internal Analitic(string text)
        {
            Text = text;
            Text = Text.ToLower();
            string[] separators = { ",", ".", "!", "?", ";", ":", " " };
            string[] article = new string[] {"to","be","it","an","as", "a", "the", "of", "at", "on", "in", "am", "is", "are", "by", "for", "and","or" ,"-"};
            string[] words = Text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            foreach (string stringKey in words)
            {
                if (!dictionary.ContainsKey(stringKey) && !article.Contains(stringKey))
                {
                    dictionary.Add(stringKey, 1);

                }
                else if (dictionary.ContainsKey(stringKey) && !article.Contains(stringKey)) {
                    dictionary[stringKey] = dictionary[stringKey] + 1;
                }

            }
            


            Console.WriteLine("Количество слов в тексте {0}", dictionary.Count);
            foreach (var pair in dictionary.OrderByDescending(pair => pair.Value))
                {
                    if (pair.Value > 3)
                    {
                    float pct = (float)pair.Value * 100 / words.Length;
                    Console.WriteLine("Слово {0}  встретилось {1} раз, или {2} %", pair.Key, pair.Value, pct);
                    }
                }
           
        
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


    }
    }



using System;
using System.Collections.Generic;

namespace playground
{
    class Program
    {

        public static Dictionary<string, int> occurancesMap = new Dictionary<string, int>();
        public static Dictionary<string, int> eventOccurances = new Dictionary<string, int>();
        public static Dictionary<string, int> oddOccurances = new Dictionary<string, int>();

        public static void notMain()
        {
            //string failingInput = "civilwartestingwhetherthatnaptionoranynartionsoconceivedandsodedicatedcanlongendureWeareqmetonagreatbattlefiemldoftzhatwarWehavecometodedicpateaportionofthatfieldasafinalrestingplaceforthosewhoheregavetheirlivesthatthatnationmightliveItisaltogetherfangandproperthatweshoulddothisButinalargersensewecannotdedicatewecannotconsecratewecannothallowthisgroundThebravelmenlivinganddeadwhostruggledherehaveconsecrateditfaraboveourpoorponwertoaddordetractTgheworldadswfilllittlenotlenorlongrememberwhatwesayherebutitcanneverforgetwhattheydidhereItisforusthelivingrathertobededicatedheretotheulnfinishedworkwhichtheywhofoughtherehavethusfarsonoblyadvancedItisratherforustobeherededicatedtothegreattdafskremainingbeforeusthatfromthesehonoreddeadwetakeincreaseddevotiontothatcauseforwhichtheygavethelastpfullmeasureofdevotionthatweherehighlyresolvethatthesedeadshallnothavediedinvainthatthisnationunsderGodshallhaveanewbirthoffreedomandthatgovernmentofthepeoplebythepeopleforthepeopleshallnotperishfromtheearth";
            //string failingInput = "abccccdd";
            //string failingInput = "ccc";
            //string failingInput = "ababababa";
            //string failingInput = "abb";
            //string failingInput = "jglknendplocymmvwtoxvebkekzfdhykknufqdkntnqvgfbahsljkobhbxkvyictzkqjqydczuxjkgecdyhixdttxfqmgksrkyvopwprsgoszftuhawflzjyuyrujrxluhzjvbflxgcovilthvuihzttzithnsqbdxtafxrfrblulsakrahulwthhbjcslceewxfxtavljpimaqqlcbrdgtgjryjytgxljxtravwdlnrrauxplempnbfeusgtqzjtzshwieutxdytlrrqvyemlyzolhbkzhyfyttevqnfvmpqjngcnazmaagwihxrhmcibyfkccyrqwnzlzqeuenhwlzhbxqxerfifzncimwqsfatudjihtumrtjtggzleovihifxufvwqeimbxvzlxwcsknksogsbwwdlwulnetdysvsfkonggeedtshxqkgbhoscjgpiel";
            //string failingInput = "tattarrattat";
            string failingInput = "";
            int result = CountOccurances(failingInput);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int CountOccurances(string s)
        {
            int sum = 0;
            int length = s.Length;
            for (int i = 0; i < length; i++)
            {
                string token = s[i].ToString();
                if (occurancesMap.ContainsKey(token))
                {
                    occurancesMap[token] = occurancesMap[token] + 1;
                }
                else
                {
                    occurancesMap.Add(token, 1);
                }
            }
            if (occurancesMap.Count == 1) {
                foreach (var entry in occurancesMap) {
                    return entry.Value;
                }
            }
            foreach (var item in occurancesMap) {
                if (item.Value % 2 == 0)
                {
                    eventOccurances.Add(item.Key, item.Value);
                }
                else
                {
                    oddOccurances.Add(item.Key, item.Value);
                }
            }
         
            foreach (KeyValuePair<string, int> keyValuePair in eventOccurances)
            {
                sum += keyValuePair.Value;
            }

            if (eventOccurances.Count > 0 && oddOccurances.Count == 1)
            {
                foreach (KeyValuePair<string, int> keyValuePair in oddOccurances)
                {
                    return sum + keyValuePair.Value;
                }
            }
            else
            {
                foreach (KeyValuePair<string, int> item in oddOccurances)
                {
                    sum += item.Value - 1;
                }
                if (oddOccurances.Count > 1) { sum++; }
            }
            return sum;
        }
    }
}

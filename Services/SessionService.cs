using ContosoConfApp.Models;
using System.Text.Json;

namespace ContosoConfApp.Services
{
    public class SessionService
    {
        public List<Session> _sessions;

        public void Initialize()
        {
            string jsonString = null;
            //using (var sr = new StringReader("C:\\Visual Studio\\ContosoConfApp\\bin\\Debug\\net6.0\\data\\data.json"))
            //{
            //    jsonString = sr.ReadToEnd();
            //}

            jsonString =
                @"[
        {
        ""speaker"": ""Michael Gonzalez"",
        ""subject"": ""How to code in C#"",
        ""date"": ""Today"",
        ""details"": ""/Home/MichaelGonzalez"",
        ""btn"": ""michael"",
        ""seats"": 10
        },
        {
        ""speaker"": ""Jordan Waite"",
        ""subject"": ""How to fly an aircraft"",
        ""date"": ""Monday September 26, 2022"",
        ""details"": ""/Home/JordanWaite"",
        ""btn"": ""jordan"",
        ""seats"": 10
        },
        {
        ""speaker"": ""Steven Ha"",
        ""subject"": ""How to cook vietnamese food"",
        ""date"": ""Tuesday September 27, 2022"",
        ""details"": ""/Home/StevenHa"",
        ""btn"": ""steven"",
        ""seats"": 10
        },
        {
        ""speaker"": ""Trevon Noble"",
        ""subject"": ""How to lift"",
        ""date"": ""Wednesday September 28, 2022"",
        ""details"": ""/Home/TrevonNoble"",
        ""btn"": ""trevon"",
        ""seats"": 10
        },
        {
        ""speaker"": ""Rabin Ghaju"",
        ""subject"": ""How to be an engineer"",
        ""date"": ""Thursday September 29, 2022"",
        ""details"": ""/Home/RabinGhaju"",
        ""btn"": ""rabin"",
        ""seats"": 10
        },
        {
        ""speaker"": ""W Clay Leimgruber"",
        ""subject"": ""Learning how to code"",
        ""date"": ""Friday September 30, 2022"",
        ""details"": ""/Home/ClayLeimgruber"",
        ""btn"": ""clay"",
        ""seats"": 10
        }
        ]";
           _sessions = JsonSerializer.Deserialize<List<Session>>(jsonString);
        }

        public List<Session> GetSessions()
        {
            return _sessions;            
        }

        public Session GetSessionDetails(int id)
        {
            // TODO
            return null;
        }

        public void ReserveSeat(int id)
        {
            _sessions[id].seats -=1;
        }
    }
}
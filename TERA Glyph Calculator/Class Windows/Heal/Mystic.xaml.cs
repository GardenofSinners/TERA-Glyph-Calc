using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using static TERA_Glyph_Calculator.JsonHandler;


namespace TERA_Glyph_Calculator.Class_Windows {

    public partial class Mystic {

        public Dictionary<string, JObject> _shipDict = new Dictionary<string, JObject>();

        public Mystic() {

            InitializeComponent();
            deserializeJson();

        }

        public void deserializeJson() {

            #region Getting to File Location
            var filepath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            filepath = Directory.GetParent(Directory.GetParent(filepath).FullName).FullName;
            filepath = filepath + "\\Json\\";
            #endregion

            #region Getting to Image Location
            var imagePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            imagePath = Directory.GetParent(Directory.GetParent(imagePath).FullName).FullName;
            imagePath = imagePath + "\\images\\Glyph Images\\";
            #endregion

            var responseData = JsonConvert.DeserializeObject<RootObject>(File.ReadAllText(filepath + "mystic.json"));

            string[] skillNames = createSkillVariables();

            //Not sure how to do this dynamically so I'll list them all out manually.

            //Sharan Bolt
            var EmpoweredSharanBolt = responseData.@class.skill[0].glyph[0].image;

            //Corruption Ring
            var SpiritedCorruptionRing = responseData.@class.skill[1].glyph[0].image; //First Glyph
            var InfluentialCorruptionRing = responseData.@class.skill[1].glyph[1].image; //Second Glyph

            //Ancient Binding
            var LingeringAncientBinding = responseData.@class.skill[2].glyph[0].image;
            var NumbingAncientBinding = responseData.@class.skill[2].glyph[1].image;

            //Titanic Favor
            var MultiplicativeTitanicFavor = responseData.@class.skill[3].glyph[0].image;
            var LongshotTitanicFavor = responseData.@class.skill[3].glyph[1].image; //lvl 20 version 
            var LongshotTitanicFavorlv58 = responseData.@class.skill[3].glyph[2].image; //lvl 58
            var LongshotTitanicFavorlv65 = responseData.@class.skill[3].glyph[3].image; //lvl 65

            //Shara's Lash
            //var LingeringSharasLashlv50 = responseData.@class.skill[4].glyph[0].image;
            //var LingeringSharasLashlv58 = responseData.@class.skill[4].glyph[1].image;
            //var FleetFootedSharasLashlv58 = responseData.@class.skill[4].glyph[2].image;

            string[] SharaGlyphArray = new string[3];
            SharaGlyphArray[0] = responseData.@class.skill[4].glyph[0].image;
            SharaGlyphArray[1] = responseData.@class.skill[4].glyph[1].image;
            SharaGlyphArray[2] = responseData.@class.skill[4].glyph[2].image;
            //Mana Infusion

            //Metamorphic Blast

            //Arun's Cleansing

            //Resurrect

            //Summon Party

            var list = new ObservableCollection<Class>();

            //Sharan Bolt
            list.Add(new Class() { A = skillNames[0], B = (imagePath + EmpoweredSharanBolt) } );
            list.Add(new Class() { A = skillNames[1], B = (imagePath + SpiritedCorruptionRing) } );
            list.Add(new Class() { A = skillNames[2], B = (imagePath + LingeringAncientBinding) });
            list.Add(new Class() { A = skillNames[3], B = (imagePath + LongshotTitanicFavor) });
            list.Add(new Class() { A = skillNames[4], B = (imagePath + SharaGlyphArray[0]) });
            list.Add(new Class() { A = skillNames[5], B = (imagePath) });
            list.Add(new Class() { A = skillNames[6], B = (imagePath) });
            list.Add(new Class() { A = skillNames[7], B = (imagePath) });
            list.Add(new Class() { A = skillNames[8], B = (imagePath) });
            list.Add(new Class() { A = skillNames[9], B = (imagePath) }); //This is the 10th skill.

            this.dataGrid1.ItemsSource = list;

        }

        public string[] createSkillVariables() {

            #region Getting to File Location
            var filepath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            filepath = Directory.GetParent(Directory.GetParent(filepath).FullName).FullName;
            filepath = filepath + "\\Json\\";
            #endregion

            string[] skillNames = new string[30]; // 30 skills change this to something more dynamic at a later date.
            var responseData = JsonConvert.DeserializeObject<RootObject>(File.ReadAllText(filepath + "mystic.json"));

            for (var i = 0; i <= 29; ++i) {

               skillNames[i] = responseData.@class.skill[i].name;

            }

            return skillNames;
        }

    }
}

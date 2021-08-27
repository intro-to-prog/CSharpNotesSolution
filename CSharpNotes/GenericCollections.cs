using CSharpNotes.Domestic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CSharpNotes
{
    public class GenericCollections
    {
        [Fact]
        public void OldSkoolCollectionsDontUseThese()
        {
            var myFavoriteNumbers = new ArrayList();
            myFavoriteNumbers.Add(9);
            myFavoriteNumbers.Add(20);
            myFavoriteNumbers.Add(108);


            Assert.Equal(108, myFavoriteNumbers[2]);

            var firstTwo = ((int)myFavoriteNumbers[0]) + ((int)myFavoriteNumbers[1]);

            Assert.Equal(29, firstTwo);

        }

        [Fact]
        public void FavoriteNumbersGenerics()
        {
            var favoriteNumbers = new List<int>();
            favoriteNumbers.Add(9);
            favoriteNumbers.Add(20);
            favoriteNumbers.Add(108);

            var firstTwo = favoriteNumbers[0] + favoriteNumbers[1];

            Assert.Equal(29, firstTwo);
        }

        [Fact]
        public void GenericDictionary()
        {
            var friends = new Dictionary<string, Friend>();
            friends.Add("sean", new Friend("Sean", "Carlin"));
            friends.Add("david", new Friend("David", "Iozzi"));
            friends.Add("amy", new Friend("Amy", "Stahl"));

            Assert.Equal("Stahl", friends["amy"].LastName);

            if (friends.ContainsKey("david"))
            {

            }
        }
        [Fact]
        public void InitializeAndEnumerateAList()
        {
            var friends = new List<string> { "Sean", "Billy", "Jamie" };

            foreach (var person in friends)
            {
                // do something with that person.
            }

        }
        [Fact]
        public void InitializeAndEnumerateADictionary()
        {
            var friends = new Dictionary<string, Friend>()
            {
                { "sean", new Friend("Sean", "Carlin") },
                { "billy", new Friend("Billy", "Farkas") }
            };

            foreach (var name in friends.Keys)
            {
                // sean, billy
            }

            foreach (var friend in friends.Values)
            {
                // Friend("Sean"...), Friend("Billy"...)
            }

            foreach (KeyValuePair<string, Friend> kvp in friends)
            {
                //{ "sean", new Friend("Sean", "Carlin") },
                //{ "billy", new Friend("Billy", "Farkas") }
            }

        }

        [Fact]
        public void ABitAboutRecords()
        {
            var kevin = new Friend("Kevin", "Coral");
            Assert.Equal("Kevin", kevin.FirstName);

            var julie = kevin with { FirstName = "Julie" };

            Assert.Equal("Julie", julie.FirstName);
            Assert.Equal("Coral", julie.LastName);
            Assert.Equal("Kevin", kevin.FirstName);
        }

        public record Friend(string FirstName, string LastName);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_paired_cards_in_Ossetian
{
    public class UsersRepository
    {
        private List<PlayerData> users = new List<PlayerData>();
        public List<PlayerData> Items
        {
            get { return new List<PlayerData>(users); }
            set
            {
                users.Clear();
                foreach (var user in value)
                {
                    users.Add(user);
                }
            }
        }

        public void Add(PlayerData newUser)
        {
            foreach (var user in users)
            {
                if (newUser.Name == user.Name)
                {
                    //объект на форме(newUser) забирает актуальный высокий уровень из базы(user)
                    newUser.Update(user);

                    user.Update(newUser);
                    return;
                }
            }
            users.Add(newUser);
        }
    }
}

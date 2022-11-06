using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PartyMemberManagementSystem.Entity
{
    public class Members
    {
        public string Name { get; set;}
        public int Sex { get; set; }
        public DateTime Dob{ get; set; }
        public string Job { get; set; }
        public Boolean CardID { get; set; }
        public string CardIDNo { get; set; }
        public Boolean SencusSeen { get; set; }
        public Boolean Migration { get; set; }
        public int MigrationID { get; set; }
        public string MigrationDetail { get; set; }
        public string Address { get; set; }
        public Boolean PeopleID { get; set; }
        public string PeopleIDNo { get; set; }
        public DateTime DateIn { get; set; }
        public Boolean VoteRegister { get; set; }
        public int VoteStation { get; set; }
        public int VoteStationNo { get; set; }
        public int RoleID { get; set; }
        public string Detail { get; set; }
        public string PhotoPath { get; set; }
        public int FamilyStatus { get; set; }
        public string SexName { get; set; }
        public string RoleName { get; set; }
        public string MigrationInOut { get; set; }
        public Image Photo { get; set; }
        public string VoteStationName { get; set; }
        public string VoteStationNoName { get; set; }
        public string FamilyStatusName { get; set; }
        //public int FamilyID { get; set; }


        public Members(string name, int sex, DateTime dob, string job, Boolean cardID, string cardIDNo, Boolean sencusSeen, Boolean migration, int migrationID, string migrationDetail, string address, Boolean peopleID, string peopleIDNo, DateTime dateIn, Boolean voteRegister, int voteStation, int voteStationNo, int roleID, string detail, string photoPath, int familyStatus, string sexname, string rolename, string migrationInNout, Image photo, string voteStationName, string voteStationNoName, string familyStatusName)
        {
            this.Name = name;
            this.Sex = sex;
            this.Dob = dob;
            this.Job = job;
            this.CardID = cardID;
            this.CardIDNo = cardIDNo;
            this.SencusSeen = sencusSeen;
            this.Migration = migration;
            this.MigrationID = migrationID;
            this.MigrationDetail = migrationDetail;
            this.Address = address;
            this.PeopleID = peopleID;
            this.PeopleIDNo = peopleIDNo;
            this.DateIn = dateIn;
            this.VoteRegister = voteRegister;
            this.VoteStation = voteStation;
            this.VoteStationNo = voteStationNo;
            this.RoleID = roleID;
            this.Detail = detail;
            this.PhotoPath = photoPath;
            this.FamilyStatus = familyStatus;
            this.SexName = sexname;
            this.RoleName = rolename;
            this.MigrationInOut = migrationInNout;
            this.Photo = photo;
            this.VoteStationName = voteStationName;
            this.VoteStationNoName = voteStationNoName;
            this.FamilyStatusName = familyStatusName;
            //this.FamilyID = familyID;
        }

        //public string Name 
        //{
        //    get { return this.name; }    
        //}

        //public Int16 Sex
        //{
        //    get { return this.sex; }
        //}
    }
}

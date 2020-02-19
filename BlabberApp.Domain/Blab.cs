namespace BlabberApp.Domain{

    public class Blab : IDatum{
        private System.DateTime _dttm;

        public System.DateTime DateTime{
            get {return this._dttom;}
            set {this._dttm = value;}
        }
        private string _userId;
        public string userID{
            get {return this.userID;}
            set {this._message = value;}
        }
        private string _userId;
        public string UserID{
            get {return this._userId;}
            set {this.userID = value;}
        }
        public string getSysId(){
            return "";
        }


    }
}
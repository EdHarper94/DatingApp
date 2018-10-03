namespace DatingApp.API.Models
{
    public class Value
    {

        private int m_id;
        public int Id
        {
            get
            {
                return m_id;
            }
            set
            {
                m_id = value;
            }
        }

        private string m_name;

        public string Name
        {
            get
            {
                return m_name;
            }
            set
            {
                m_name = value;
            }     
        }
    }
}
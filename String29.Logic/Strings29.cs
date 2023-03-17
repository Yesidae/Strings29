namespace String.Logic
{
    public class Strings29
    {
        private readonly string _bridge;

        public Strings29(string text)
        {
            _bridge = text;
        }

        public bool Bridge()
        {
            string bridge = _bridge;
            int booster = 0; //refuerzo
            int platform = 0; //plataforma

            int n = bridge.Length / 2;
            if (bridge[0] != '*')
            {
                for (int i = 0; i < n; i++)
                {
                    if (bridge[i] != bridge[bridge.Length - i - 1])
                    {
                        return false;
                    }

                    //if (bridge[i] == '=' || bridge[i] == '+')
                    //{
                    //    if (bridge[i] == '=')
                    //    {
                    //        platform++;
                    //    }

                    //    if (platform == 3)
                    //    {
                    //        return false;
                    //    } 
                    //}
                }
                
            }
            return true;
        }
    }
}
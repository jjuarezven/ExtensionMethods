﻿namespace ExtensionMethods.Library
{
    public class Target
    {
        private string _id;

        protected string Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value.Trim();
            }
        }

        public string GetId()
        {
            return Id;
        }

        public Target(string id)
        {
            _id = id;
        }
    }

    internal class InternalTarget
    {
        protected class ProtectedSubClass
        {

        }
    }
}

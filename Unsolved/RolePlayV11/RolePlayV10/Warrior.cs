﻿namespace RolePlayV11
{
    public class Warrior
    {
        // Instance fields
        private string _name;
        private int _level;

        // Constructor
        public Warrior(string name)
        {
            _name = name;
            _level = 1;
        }

        // Properties
        public string Name
        {
            get { return _name; }
        }

        public int Level
        {
            get { return _level; }
        }

        // Methods (just one here so far...)
        public void LevelUp()
        {
            _level = _level + 1;
        }
    }
}
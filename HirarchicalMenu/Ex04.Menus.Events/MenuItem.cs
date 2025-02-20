using System;
using System.Collections.Generic;
using Ex04.Menus.Events;

namespace Ex04.Menus.Events
{
    public class MenuItem
    {
        private string m_MenuTitle;
        private List<MenuItem> m_ListOfSubItems;
        private MenuItem m_PreviousMenuItem;
        private event Action m_FunctionToExecute;

        public string MenuTitle
        {
            get { return m_MenuTitle; }
            set { m_MenuTitle = value; }
        }

        public List<MenuItem> ListOfSubItems
        {
            get { return m_ListOfSubItems; }
            set { m_ListOfSubItems = value; }
        }

        public MenuItem PreviousMenuItem
        {
            get { return m_PreviousMenuItem; }
            set { m_PreviousMenuItem = value; }
        }

        public event Action OnItemSelected
        {
            add { m_FunctionToExecute += value; }
            remove { m_FunctionToExecute -= value; }
        }

        public MenuItem(string i_MenuTitle)
        {
            m_MenuTitle = i_MenuTitle;
            m_ListOfSubItems = new List<MenuItem>();
        }

        public void AddSubItem(MenuItem i_SubItem)
        {
            i_SubItem.m_PreviousMenuItem = this;
            m_ListOfSubItems.Add(i_SubItem);
        }

        public void NotifySelection()
        {
            if (m_FunctionToExecute != null)
            {
                m_FunctionToExecute.Invoke();
            }
        }
    }
}

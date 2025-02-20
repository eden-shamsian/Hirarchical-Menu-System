using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        private string m_MenuTitle;
        private IMenuAction m_Action;
        private List<MenuItem> m_ListOfSubItems;
        private MenuItem m_PreviousMenuItem;
        private readonly IMenuListener r_MenuListener;

        public string MenuTitle
        {
            get { return m_MenuTitle; }
            set { m_MenuTitle = value; }
        }

        public IMenuAction Action
        {
            get { return m_Action; }
            set { m_Action = value; }
        }

        public List<MenuItem> SubItems
        {
            get { return m_ListOfSubItems; }
            set { m_ListOfSubItems = value; }
        }

        public MenuItem PreviousMenuItem
        {
            get { return m_PreviousMenuItem; }
            set { m_PreviousMenuItem = value; }
        }

        public IMenuListener MenuListener
        {
            get { return r_MenuListener; }
        }

        public MenuItem(string i_MenuTitle, IMenuAction i_Action = null, IMenuListener i_MenuListener = null)
        {
            m_MenuTitle = i_MenuTitle;
            m_Action = i_Action;
            m_ListOfSubItems = new List<MenuItem>();
            r_MenuListener = i_MenuListener;
        }

        public void AddSubItem(MenuItem i_SubItem)
        {
            i_SubItem.m_PreviousMenuItem = this;
            m_ListOfSubItems.Add(i_SubItem);
        }

        public void NotifySelection()
        {
            if (r_MenuListener != null)
            {
                r_MenuListener.OnMenuItemSelected(this);
            }
        }
    }
}
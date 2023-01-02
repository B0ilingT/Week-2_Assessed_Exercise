using System;
using System.Collections.Generic;
using System.Text;

namespace Journal_Linked_List
{
    class Journal : IComparable
    {
        protected string title;
        protected string author;
        protected string pubYear;
        protected string journalTitle;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string TitleJo
        {
            get { return journalTitle; }
            set { journalTitle = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string PubYear
        {
            get { return pubYear; }
            set { pubYear = value; }
        }

        public Journal(string author, string title, string journalTitle, string pubYear)
        {
            this.title = title;
            this.author = author;
            this.pubYear = pubYear;
            this.journalTitle = journalTitle;
        }
        public int CompareTo(object obj)
        {
            Journal other = (Journal)obj;
            return Author.CompareTo(other.Author);
        }
        public override string ToString()
        {
            return "Author: " + author + ", Title: " + title + ", JournalTitle: " + journalTitle + ", Publication Year: " + pubYear;
        }
    }
}

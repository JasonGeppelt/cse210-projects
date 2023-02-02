using System;

class Entry
{
    public string _dateAndTime;
    public string _body;
    public DateTime GetDateTime()
    {
        return DateTime.Now;
    }
}
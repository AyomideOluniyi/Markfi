﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

public class User
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}

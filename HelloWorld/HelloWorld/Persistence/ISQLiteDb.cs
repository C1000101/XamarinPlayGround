﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace HelloWorld.Persistence
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}

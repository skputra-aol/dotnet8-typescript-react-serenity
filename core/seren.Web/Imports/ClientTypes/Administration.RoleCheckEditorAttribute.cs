using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace seren.Administration;

public partial class RoleCheckEditorAttribute : CustomEditorAttribute
{
    public const string Key = "seren.Administration.RoleCheckEditor";

    public RoleCheckEditorAttribute()
        : base(Key)
    {
    }
}
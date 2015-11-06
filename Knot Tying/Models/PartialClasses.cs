using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Knot_Tying.Models
{
    [MetadataType(typeof(SchoolMetadata))]
    public partial class School
    {
    }

    [MetadataType(typeof(CompetitionEntryMetaData))]
    public partial class CompetitionEntry
    {
    }
}
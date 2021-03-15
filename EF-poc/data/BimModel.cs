using Npgsql;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_poc.data
{
    [Table("models", Schema ="public")]
    public class BimModel
    {
        [Key]
        [StringLength(255)]
        public string id { get; set; }

        [Required]
        [StringLength(255)]
        public string project_id { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        [Required]
        [StringLength(255)]
        public string discipline { get; set; }

        [Required]
        [StringLength(255)]
        public string description { get; set; }

        [Required]
        public NpgsqlParameter<NpgsqlTypes.NpgsqlDbType> bim_parameters { get; set; }

        public BimModel(string id, string project_id, string name, string discipline, string description, string bim_parameters)
        {
            this.id = id;
            this.project_id = project_id;
            this.name = name;
            this.discipline = discipline;
            this.description = description;
            this.bim_parameters = new NpgsqlParameter<NpgsqlTypes.NpgsqlDbType>(bim_parameters, NpgsqlTypes.NpgsqlDbType.Jsonb);
        }

        public BimModel()
        {

        }
    }
}

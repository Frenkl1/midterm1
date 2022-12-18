[HttpPost]
        public IActionResult AddStudent([FromBody] StudentVM schoolVM)
        {
            //Krijohet objekti student
            var school = new School()
            {
                //Id = Gjenerohet nga database
                FirstName = studentVM.FirstName,
                LastName=studentVM.LastName,
                GraduationYear = studentvm.GraduationYear,
                IsActive = studentVM.IsActive,
                DateOfBirth = studentVM.DateOfBirth,

            };

            //Objekti Student i krijuar shtohet ne databaze me Entity Framework
            return Created("", student);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent([FromBody]StudentVM StudentVM, int id)
        {
            //Merret objekti Student nga database duket perdorur Id si parameter
            var student = new Student()
            {
                FirstName = "Frenkli",
                LastName = "Orgocka",
                GraduationYear = "2023",
                IsActive = true,
                DateOfBirth = DateTime.Now.AddYears(-20),
            };


            //Modifikohet objekti School i marre nga databaza duket perdorur te dhenat nga FromBody
            school.Name = schoolVM.Name;
            school.Address = schoolVM.Address;
            school.YearEstablished = schoolVM.YearEstablished;
            school.DateUpdated = DateTime.UtcNow;

            //Perditesohet objekti shkolle ne database me Entity Framework

            return Ok($"School with id = {id} was updated");
        }
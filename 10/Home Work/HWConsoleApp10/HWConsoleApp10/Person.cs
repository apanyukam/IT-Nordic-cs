using System;
using System.Collections.Generic;
using System.Text;


class Person
{
	public string NamePerson { get; set; }
	public int AgePerson { get; set; }

	public int AgePersonForYear
	{
		get
		{
			int agePersonForYear = AgePerson + 4;
			return agePersonForYear;
		}
	}

	public string DisplayInfoAboutPerson
	{
		get
		{
			return $"Возраст друга по имени {NamePerson} через 4 года: {AgePersonForYear}";
		}
	}
}







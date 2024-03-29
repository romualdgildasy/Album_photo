using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie2
{

	class ElementParDefaut<T>
	{
		private List<T> elements = new List<T>();
		private T elementParDefaut;

		public void AjouterElement(T element)
		{
			elements.Add(element);
			if (elementParDefaut == null)
			{
				elementParDefaut = element;
			}
		}

		public void SupprimerElement(T element)
		{
			elements.Remove(element);
			if (elementParDefaut.Equals(element))
			{
				elementParDefaut = elements.Count > 0 ? elements[0] : default(T);
			}
		}

		public void ChoisirElementParDefaut(T element)
		{
			if (elements.Contains(element))
			{
				elementParDefaut = element;
			}
			else
			{
				Console.WriteLine("L'élément spécifié n'est pas dans la collection.");
			}
		}
	}
}







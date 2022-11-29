#include "algobase.h"

namespace mystl
{


	template <class InputIter1, class InputIter2>
	bool lexicographical_compare(InputIter1 first1, InputIter1 last1,
		InputIter2 first2, InputIter2 last2)
	{
		for (; first1 != last1 && first2 != last2; ++first1, ++first2)
		{
			if (*first1 < *first2)
				return true;
			if (*first2 < *first1)
				return false;
		}
		return first1 == last1 && first2 != last2;
	}

	template <class InputIter1, class InputIter2, class Compred>
	bool lexicographical_compare(InputIter1 first1, InputIter1 last1,
		InputIter2 first2, InputIter2 last2, Compred comp)
	{
		for (; first1 != last1 && first2 != last2; ++first1, ++first2)
		{
			if (comp(*first1, *first2))
				return true;
			if (comp(*first2, *first1))
				return false;
		}
		return first1 == last1 && first2 != last2;
	}

	bool lexicographical_compare(const unsigned char* first1,
		const unsigned char* last1,
		const unsigned char* first2,
		const unsigned char* last2)
	{
		const auto len1 = last1 - first1;
		const auto len2 = last2 - first2;
		// 先比较相同长度的部分
		const auto result = std::memcmp(first1, first2, mystl::MIN(len1, len2));
		// 若相等，长度较长的比较大
		return result != 0 ? result < 0 : len1 < len2;
	}
}
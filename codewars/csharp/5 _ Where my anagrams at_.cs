//What is an anagram? Well, two words are anagrams of each other if they both contain the same letters. For example:
//'abba' & 'baab' == true
//'abba' & 'abca' == false
//Write a function that will find all the anagrams of a word from a list. You will be given two inputs a word and an array with words. You should return an array of all the anagrams or an empty array if there are none. For example:
//anagrams('abba', ['aabb', 'abcd', 'bbaa', 'dada']) => ['aabb', 'bbaa']
//anagrams('laser', ['lazing', 'lazy',  'lacer']) => []
using System.Linq;
using System.Collections.Generic;
using System;

public static class Kata
{
  public static List<string> Anagrams(string word, List<string> words) => words.Where(n => String.Concat(n.OrderBy(c=>c))  ==  String.Concat(word.OrderBy(c=>c))).ToList();
}

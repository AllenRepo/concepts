using System;
using Xunit;

namespace Fundamental
{
    public class TrieNode
    {
        private const int ENGLISH_ALPHABET_SIZE = 26;

        public TrieNode[] Childrens;
        public bool IsEndOfWord = false;

        public TrieNode()
        {
            Childrens = new TrieNode[ENGLISH_ALPHABET_SIZE];
        }
    }

    public class Trie
    {
        private readonly TrieNode root;
        public Trie()
        {
            root = new TrieNode();
        }
        public void Insert(string word)
        {
            var current = root;
            foreach(var character in word)
            {
                var index = GetCharacterIndexWithinArray(character);
                if (current.Childrens[index] == null)
                {
                    current.Childrens[index] = new TrieNode();
                }
                current = current.Childrens[index];
            }
            current.IsEndOfWord = true;
        }

        public bool Search(string word)
        {
            var current = root;
            foreach(var character in word)
            {
                var index = GetCharacterIndexWithinArray(character);
                if (current.Childrens[index] == null)
                {
                    return false;
                }
                current = current.Childrens[index];
            }
            return current.IsEndOfWord;
        }

        public int GetCharacterIndexWithinArray(char character)
        {
            return character - 'a';
        }
    }

    public class TrieTests
    {
        private Trie trie;
        public TrieTests()
        {
            trie = new Trie();
        }

        [Theory]
        [InlineData("hello", "hello")]
        public void should_evaluate_truthy_search_result(string wordToFind, params string[] wordsToInsert)
        {
            // arrange
            foreach(var word in wordsToInsert)
            {
                trie.Insert(word);
            }

            // act
            var searchResult = trie.Search(wordToFind);

            // assert
            Assert.True(searchResult);
        }

        [Theory]
        [InlineData("hello", "helloz")]
        [InlineData("hello", "hella")]
        [InlineData("hellow", "hello")]
        public void should_evaluate_falsy_search_result(string wordToFind, params string[] wordsToInsert)
        {
            // arrange
            foreach (var word in wordsToInsert)
            {
                trie.Insert(word);
            }

            // act
            var searchResult = trie.Search(wordToFind);

            // assert
            Assert.False(searchResult);
        }
    }
}

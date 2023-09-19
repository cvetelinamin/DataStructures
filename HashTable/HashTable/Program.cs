using HashTableProject;


HashTable hashTable = new HashTable(2);
hashTable.set("grapes", 1000);
hashTable.set("apples", 54);
hashTable.keys();
Console.Write(hashTable.get("apples"));
hashTable.keys();
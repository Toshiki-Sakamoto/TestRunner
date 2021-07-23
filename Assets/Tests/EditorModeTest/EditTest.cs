using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class EditTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void EditTestSimplePasses()
    {
        // trueチェックにあえてfalseを渡して失敗させる
        Assert.True(false);
    }
}

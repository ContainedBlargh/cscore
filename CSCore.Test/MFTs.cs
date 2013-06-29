﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSCore.DMO;
using CSCore.DSP;
using CSCore.Streams;
using CSCore.Streams.SampleConverter;

namespace CSCore.Test
{
    [TestClass]
    public class MFTs
    {
        [TestMethod]
        [TestCategory("DMO")]
        public void DmoResamplerComTest()
        {
            WMResampler resampler = new WMResampler();
            resampler.Dispose();
        }

        /*[TestMethod]
        [TestCategory("DMO")]
        public void DmoResamplerTest()
        {
            var source = new SampleToRaw16(new SineGenerator());
            using (DmoResampler resampler = new DmoResampler(source, 11500))
            {
                byte[] buffer = new byte[source.WaveFormat.BytesPerSecond / 2];
                if (resampler.Read(buffer, 0, buffer.Length) != buffer.Length)
                {
                    throw new Exception("Could not fill the whole buffer");
                }
            }
        }*/
    }
}
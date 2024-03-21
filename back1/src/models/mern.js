const express = require("express");
const mongoose = require("mongoose");

const abcSchema = new mongoose.Schema({
  name: {
    type: String,
    required: true,
  },
  address: {
    type: String,
    required: true,
  },
});

const AbcData = new mongoose.model("AbcDataabc", abcSchema);

module.export = AbcData;

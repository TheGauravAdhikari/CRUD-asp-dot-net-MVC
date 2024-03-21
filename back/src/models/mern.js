const express = require("express");
const mongoose = require("mongoose");

const mernSchema = new mongoose.Schema({
  name: {
    type: String,
    required: true,
  },
  rollno: {
    type: String,
    required: true,
  },
});

const MernRanking = new mongoose.model("MernRankabc", mernSchema);

module.exports = MernRanking;

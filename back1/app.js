const express = require("express");

const app = express();

require("./db/conn");

const AbcData = require("./src/models/mern");

const port = process.env.PORT || 3002;

app.listen(() => {
  console.log(`Run At port ${port}`);
});

app.post("/abc", async (req, res) => {
  try {
    const addData = new AbcData(req.body);
    addData.save();
  } catch (e) {
    res.send(e);
  }
});

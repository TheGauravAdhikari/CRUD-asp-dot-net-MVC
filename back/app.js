const express = require("express");

const app = express();
require("./src/db/conn");

app.use(express.json());

const MernRanking = require("./src/models/mern");
const port = process.env.PORT || 3005;

app.listen(port, () => {
  console.log(`Connection to live at port a ${port}`);
});

app.post("/mern", async (req, res) => {
  try {
    const addMern = new MernRanking(req.body);

    console.log(req.body);
    addMern.save();
  } catch (e) {
    res.send(e);
  }
});

app.get("/", (req, res) => {
  res.send("Hello From the Gaurav Adhikari");
});

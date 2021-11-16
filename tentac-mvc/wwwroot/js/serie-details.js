"use strict";
import { handleClickEvents, handleSeriePage } from "./helper.js";

$(document).ready(async () => {
  handleClickEvents();
  await handleSeriePage();
});

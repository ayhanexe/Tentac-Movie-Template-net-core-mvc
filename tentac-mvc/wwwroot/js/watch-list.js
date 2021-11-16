"use strict";
import {
  handleWatchListPage,
  handleClickEvents,
} from "./helper.js";

$(document).ready(async () => {
  await handleWatchListPage();
  handleClickEvents();
});

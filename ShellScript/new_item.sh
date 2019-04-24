#!/bin/bash
echo -e "\e[105m\e[1mWhat is the suffix of the new item's ?\e[0m"
read sSuffixItem
echo "OK, now..."
read -p "Based some item already exists (y/n) " choice
case "$choice" in
  y|Y )
    echo -e "\e[106m\e[1mWhat is the suffix of that item ?\e[0m"
    read sSuffixItemBased
    read -p "Name of the license: " sLicenseNameBased
    read -p "Name of the module: " sModuleNameBased
    read -p "Name of the item: " sItemNameBased
    bBasedItemAlreadyExists=true;
    ;;
  n|N )
    bBasedItemAlreadyExists=false;
    ;;
  * )
    bBasedItemAlreadyExists=false;
    ;;
esac
read -p "Do you want create model (y/n) " choice
case "$choice" in
  y|Y )
    bCreateModel=true
    ;;
  n|N )
    bCreateModel=false
    ;;
  * )
    bCreateModel=false
    ;;
esac
read -p "Do you want create view (y/n) " choice
case "$choice" in
  y|Y )
    bCreateView=true
    ;;
  n|N )
    bCreateView=false
    ;;
  * )
    bCreateView=false
    ;;
esac
read -p "Do you want create controller (y/n) " choice
case "$choice" in
  y|Y )
    bCreateController=true
    ;;
  n|N )
    bCreateController=false
    ;;
  * )
    bCreateController=false
    ;;
esac
read -p "Do you want create stylesheet (y/n) " choice
case "$choice" in
  y|Y )
    bCreateStylesheet=true
    ;;
  n|N )
    bCreateStylesheet=false
    ;;
  * )
    bCreateStylesheet=false
    ;;
esac
read -p "Do you want create spreadsheet (y/n) " choice
case "$choice" in
  y|Y )
    bCreateSpreadsheet=true
    ;;
  n|N )
    bCreateSpreadsheet=false
    ;;
  * )
    bCreateSpreadsheet=false
    ;;
esac
read -p "Do you want create pdf (y/n) " choice
case "$choice" in
  y|Y )
    bCreatePDF=true
    ;;
  n|N )
    bCreatePDF=false
    ;;
  * )
    bCreatePDF=false
    ;;
esac
echo "OK, now..."
read -p "Name of the license: " sLicenseName
read -p "Name of the module: " sModuleName
read -p "Name of the item: " sItemName
sColorRed=\e[31m
sBold=\e[1m
sColorBlack=\e[30m
echo "Creation summary..."
if [ "$bCreateModel" == true ]
then
  echo -e "Model: \e[34mmod\e[31m\e[1m$sSuffixItem\e[0m.php"
fi
if [ "$bCreateView" == true ]
then
  echo -e "View: \e[34mgui\e[31m\e[1m$sSuffixItem\e[0m.php"
fi
if [ "$bCreateController" == true ]
then
  echo -e "Controller: \e[34mctr\e[31m\e[1m$sSuffixItem\e[0m.js"
fi
if [ "$bCreateStylesheet" == true ]
then
  echo -e "StyleSheet: \e[34msty\e[31m\e[1m$sSuffixItem\e[0m.css"
fi
if [ "$bCreateSpreadsheet" == true ]
then
  echo -e "SpreadSheet: \e[34msps\e[31m\e[1m$sSuffixItem\e[0m.php"
fi
if [ "$bCreatePDF" == true ]
then
  echo -e "PDF: \e[34mpdf\e[31m\e[1m$sSuffixItem\e[0m.php"
fi
read -p "Confirm (y/n) " choice
case "$choice" in
  y|Y )
  if [ $bCreateModel == true ]
  then
    if [ $bBasedItemAlreadyExists == true ]
    then
      cp "/Storage/Practiko/server/$sLicenseNameBased/forms/$sModuleNameBased/php/$sItemNameBased/mod$sSuffixItemBased.php" "/Storage/Practiko/server/$sLicenseName/forms/$sModuleName/php/$sItemName/"
      mv "/Storage/Practiko/server/$sLicenseName/forms/$sModuleName/php/$sItemName/mod$sSuffixItemBased.php" "/Storage/Practiko/server/$sLicenseName/forms/$sModuleName/php/$sItemName/mod$sSuffixItem.php"
    else
      touch "/Storage/Practiko/server/$sLicenseName/forms/$sModuleName/php/$sItemName/mod$sSuffixItem.php"
    fi
  fi
  if [ $bCreateView == true ]
  then
    if [ $bBasedItemAlreadyExists == true ]
    then
      cp "/Storage/Practiko/server/$sLicenseNameBased/forms/$sModuleNameBased/php/$sItemNameBased/gui$sSuffixItemBased.php" "/Storage/Practiko/server/$sLicenseName/forms/$sModuleName/php/$sItemName/"
      mv "/Storage/Practiko/server/$sLicenseName/forms/$sModuleName/php/$sItemName/gui$sSuffixItemBased.php" "/Storage/Practiko/server/$sLicenseName/forms/$sModuleName/php/$sItemName/gui$sSuffixItem.php"
    else
      touch "/Storage/Practiko/server/$sLicenseName/forms/$sModuleName/php/$sItemName/gui$sSuffixItem.php"
    fi
  fi
  if [ $bCreateController == true ]
  then
    if [ $bBasedItemAlreadyExists == true ]
    then
      cp "/Storage/Practiko/server/$sLicenseNameBased/forms/$sModuleNameBased/js/ctr$sSuffixItemBased.js" "/Storage/Practiko/server/$sLicenseName/forms/$sModuleName/js/"
      mv "/Storage/Practiko/server/$sLicenseName/forms/$sModuleName/js/ctr$sSuffixItemBased.js" "/Storage/Practiko/server/$sLicenseName/forms/$sModuleName/js/ctr$sSuffixItem.js"
    else
      touch "/Storage/Practiko/server/$sLicenseName/forms/$sModuleName/js/ctr$sSuffixItem.js"
    fi
  fi
  if [ $bCreateStylesheet == true ]
  then
    if [ $bBasedItemAlreadyExists == true ]
    then
      cp "/Storage/Practiko/server/$sLicenseNameBased/forms/$sModuleNameBased/css/sty$sSuffixItemBased.css" "/Storage/Practiko/server/$sLicenseName/forms/$sModuleName/css/"
      mv "/Storage/Practiko/server/$sLicenseName/forms/$sModuleName/css/sty$sSuffixItemBased.css" "/Storage/Practiko/server/$sLicenseName/forms/$sModuleName/css/sty$sSuffixItem.css"
    else
      touch "/Storage/Practiko/server/$sLicenseName/forms/$sModuleName/css/sty$sSuffixItem.css"
    fi
  fi
  if [ $bCreateSpreadsheet == true ]
  then
    if [ $bBasedItemAlreadyExists == true ]
    then
      cp "/Storage/Practiko/server/$sLicenseNameBased/forms/$sModuleNameBased/php/$sItemNameBased/sps$sSuffixItemBased.php" "/Storage/Practiko/server/$sLicenseName/forms/$sModuleName/php/$sItemName/"
      mv "/Storage/Practiko/server/$sLicenseName/forms/$sModuleName/php/$sItemName/sps$sSuffixItemBased.php" "/Storage/Practiko/server/$sLicenseName/forms/$sModuleName/php/$sItemName/sps$sSuffixItem.php"
    else
      touch "/Storage/Practiko/server/$sLicenseName/forms/$sModuleName/php/$sItemName/sps$sSuffixItem.php"
    fi
  fi
  if [ $bCreatePDF == true ]
  then
    if [ $bBasedItemAlreadyExists == true ]
    then
      cp "/Storage/Practiko/server/$sLicenseNameBased/forms/$sModuleNameBased/php/$sItemNameBased/pdf$sSuffixItemBased.php" "/Storage/Practiko/server/$sLicenseName/forms/$sModuleName/php/$sItemName/"
      mv "/Storage/Practiko/server/$sLicenseName/forms/$sModuleName/php/$sItemName/pdf$sSuffixItemBased.php" "/Storage/Practiko/server/$sLicenseName/forms/$sModuleName/php/$sItemName/pdf$sSuffixItem.php"
    else
      touch "/Storage/Practiko/server/$sLicenseName/forms/$sModuleName/php/$sItemName/pdf$sSuffixItem.php"
    fi
  fi
    ;;
  n|N )
    echo "OK nothing did it"
    ;;
  * )
    echo "OK nothing did it"
    ;;
esac

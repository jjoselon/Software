<?php
function getNodeAttributes($html, $nodeFilter = "p", $attributes = array()) {
    $data = array();
    $crawler = new Crawler();
    $crawler->addHtmlContent($html);
    $nodesAttributes = $crawler->filter($nodeFilter)->extract($attributes);
    foreach ($nodesAttributes as $nodeAttributes) {
        $data[] = array_combine($attributes, $nodeAttributes);
    }
    return $data;
}

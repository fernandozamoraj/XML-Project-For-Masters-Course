<?xml version="1.0" encoding="UTF-8" ?>
<!--
   Author: Team 1 
   Date:   4/10/2010

   Filename:         PicassosInventory.xsl
   Supporting Files: PicassoProducts.xml, products.xsd
-->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
   <xsl:output method="html" version="4.0" />
<xsl:template match = "ProductGraph">
   <html> 
    <head>
       <title>Picasso's Products Inventory</title>
       <style type="text/css">  
            &lt;!--  body {  
             font-family: verdana, arial, sans-serif; 
              }  
              h1 {  
               font-size: 100%;  
               }
               td {
                border-right: 1px solid #777777;
                border-left: 1px solid #777777;
              border-top: 1px solid #777777;
              border-bottom: 1px solid #777777;
              padding: 6px 6px 6px 12px;
              font-size: 85%;
            } 
            
            
            td.noborder {
                border-right: 0px solid #FFFFFF;
                border-left: 0px solid #FFFFFF;
              border-top: 0px solid #FFFFFF;
              border-bottom: 0px solid #FFFFFF;
              padding: 6px 6px 6px 12px;
            } 
            
            table.picassotable
            {
          background:#AABBCC;
            }

      tr.darkrow  {
        background: #BBBBBB;
      }
      
      tr.lightrow  {
        background: #FFFFFF;
      }
      
               a {
                  text-decoration: none;  
                  } 
                p {
                   font-size: 65%; 
                    }  --&gt; 
                    
                 </style>
    </head>
    <body>
      <h1 align="center"><img alt="picasso logo.png" src="./images/picasso_logo.png"></img></h1>
      <table cellpadding="10" border="0">
      <tr>
      <td class="tdnoborder">  
         <table border="0" cellpadding="0" class="picassotable"  align="center">
                <tr>
                    <th>No</th> 
                    <th>Name</th>
          <th>Contact Name</th>
          <th>Phone Number</th>
        </tr>
        <xsl:for-each select="./Suppliers/Vendor">
            <xsl:sort select="Name"/>
          <xsl:apply-templates select="./Suppliers/Vendor"/>
            <xsl:if test="position() mod 2 = 0">
              <tr class="lightrow">
                <td class="tdtext"><xsl:number value="position()" format="1"></xsl:number></td>
                <td><xsl:value-of select="Name"/></td>
                  <td align="left"><xsl:value-of select="PointOfContact"/></td>
                  <td align="right"><xsl:value-of select="PhoneNumber"/></td>
              </tr>
            </xsl:if>    
            <xsl:if test="not(position() mod 2 = 0)">
              <tr class="darkrow">
                <td class="tdtext"><xsl:number value="position()" format="1"></xsl:number></td>
                <td><xsl:value-of select="Name"/></td>
                  <td align="left"><xsl:value-of select="PointOfContact"/></td>
                  <td align="right"><xsl:value-of select="PhoneNumber"/></td>
              </tr>
            </xsl:if>
        </xsl:for-each>        
         </table>
         </td>   
         </tr>
         <tr>
         <td class="tdnoborder">
         <table border="0" cellpadding="0" align="center"  class="picassotable" >
                <tr>
                    <th >Item ID</th>          
          <th>Vendor</th>
          <th>Description</th>
          <th>Location</th>
          <th>ROP</th>
          <th>RO</th>
          <th>On Hand</th>
          <th>Unit Cost</th>
          <th>Total</th>
        </tr>
        <xsl:for-each select="./Inventory/InventoryItems/InventoryItem">
            <xsl:sort select="@Id"/>
            <xsl:apply-templates select="./Inventory/InventoryItems/InventoryItem"/>
            <xsl:if test="position() mod 2 = 0">
              <tr class="lightrow">    
                <xsl:variable name="locationId" select="@LocationId"/>
                  <xsl:variable name="catalogId" select="@CatalogItemId"/> 
                  <xsl:variable name="catalogUnitCost" select="../../../Catalog/CatalogItems/CatalogItem[@Id = $catalogId]/UnitCost"/>
                  <xsl:variable name="boxedUnitCost" select="../../../Catalog/BoxedItems/BoxedItem[@Id = $catalogId]/UnitCost"/>
                  <xsl:variable name="volumeUnitCost" select="../../../Catalog/VolumeItems/VolumeItem[@Id = $catalogId]/UnitCost"/>
                  <xsl:variable name="catalogVendorId" select="../../../Catalog/CatalogItems/CatalogItem[@Id = $catalogId]/@VendorId"/>
                  <xsl:variable name="boxedVendorId" select="../../../Catalog/BoxedItems/BoxedItem[@Id = $catalogId]/@VendorId"/>
                  <xsl:variable name="volumeVendorId" select="../../../Catalog/VolumeItems/VolumeItem[@Id = $catalogId]/@VendorId"/>
                  <xsl:variable name="qtyOnHand" select="QtyOnHand"/>
                  
                <!-- <td class="tdtext"><xsl:number value="position()" format="1"></xsl:number></td>-->
                                <td><xsl:value-of select="@Id"/></td>
                <td>
                                        <xsl:call-template name="GetVendor">
                                  <xsl:with-param name="catalogVendorId" select="$catalogVendorId"/>
                                  <xsl:with-param name="boxedVendorId" select="$boxedVendorId"/>
                                  <xsl:with-param name="volumeVendorId" select="$volumeVendorId"/>
                                  <xsl:with-param name="vendors" select="../../../Suppliers"/>
                                </xsl:call-template>                  
                </td>                  
                  <td>
                           <xsl:value-of select="../../../Catalog/CatalogItems/CatalogItem[@Id = $catalogId]/Description"/>
                           <xsl:value-of select="../../../Catalog/BoxedItems/BoxedItem[@Id = $catalogId]/Description"/>
                           <xsl:value-of select="../../../Catalog/VolumeItems/VolumeItem[@Id = $catalogId]/Description"/>                           
                  </td>
                  <td align="left"><xsl:value-of select="../../Locations/Location[@Id = $locationId]/Name"/></td>
                  <td align="right"><xsl:value-of select="ReOrderPoint"/></td>
                  <td align="right"><xsl:value-of select="ReOrderQuantity"/></td>
                  <td align="right"><xsl:value-of select="QtyOnHand"/></td>
                  <td align="right">
                                    <xsl:call-template name="GetUnitCost">
                              <xsl:with-param name="catalogUnitCost" select="$catalogUnitCost"/>
                              <xsl:with-param name="boxedUnitCost" select="$boxedUnitCost"/>
                              <xsl:with-param name="volumeUnitCost" select="$volumeUnitCost"/>
                            </xsl:call-template>                  
                  </td>
                  <td align="right">
                                        <xsl:call-template name="GetTotalCost">
                                  <xsl:with-param name="catalogUnitCost" select="$catalogUnitCost"/>
                                  <xsl:with-param name="boxedUnitCost" select="$boxedUnitCost"/>
                                  <xsl:with-param name="volumeUnitCost" select="$volumeUnitCost"/>
                                  <xsl:with-param name="qtyOnHand" select="$qtyOnHand"/>
                                </xsl:call-template>                  
                  </td>
                  <!--<td align="right"><xsl:value-of select="format-number(itemQty * itemPrice, '$##,##0.00' )"/></td-->
            </tr>
            </xsl:if>
            <xsl:if test="not(position() mod 2 = 0)">
              <tr class="darkrow">    
                <xsl:variable name="locationId" select="@LocationId"/>
                  <xsl:variable name="catalogId" select="@CatalogItemId"/> 
                  <xsl:variable name="catalogUnitCost" select="../../../Catalog/CatalogItems/CatalogItem[@Id = $catalogId]/UnitCost"/>
                  <xsl:variable name="boxedUnitCost" select="../../../Catalog/BoxedItems/BoxedItem[@Id = $catalogId]/UnitCost"/>
                  <xsl:variable name="volumeUnitCost" select="../../../Catalog/VolumeItems/VolumeItem[@Id = $catalogId]/UnitCost"/>
                  <xsl:variable name="catalogVendorId" select="../../../Catalog/CatalogItems/CatalogItem[@Id = $catalogId]/@VendorId"/>
                  <xsl:variable name="boxedVendorId" select="../../../Catalog/BoxedItems/BoxedItem[@Id = $catalogId]/@VendorId"/>
                  <xsl:variable name="volumeVendorId" select="../../../Catalog/VolumeItems/VolumeItem[@Id = $catalogId]/@VendorId"/>
                  <xsl:variable name="qtyOnHand" select="QtyOnHand"/>
                  
                <!-- <td class="tdtext"><xsl:number value="position()" format="1"></xsl:number></td>-->
                <td><xsl:value-of select="@Id"/></td>
                <td>
                                        <xsl:call-template name="GetVendor">
                                  <xsl:with-param name="catalogVendorId" select="$catalogVendorId"/>
                                  <xsl:with-param name="boxedVendorId" select="$boxedVendorId"/>
                                  <xsl:with-param name="volumeVendorId" select="$volumeVendorId"/>
                                  <xsl:with-param name="vendors" select="../../../Suppliers"/>
                                </xsl:call-template>                  
                </td>
                  <td>
                           <xsl:value-of select="../../../Catalog/CatalogItems/CatalogItem[@Id = $catalogId]/Description"/>
                           <xsl:value-of select="../../../Catalog/BoxedItems/BoxedItem[@Id = $catalogId]/Description"/>
                           <xsl:value-of select="../../../Catalog/VolumeItems/VolumeItem[@Id = $catalogId]/Description"/>                           
                  </td>
                  <td align="left"><xsl:value-of select="../../Locations/Location[@Id = $locationId]/Name"/></td>
                  <td align="right"><xsl:value-of select="ReOrderPoint"/></td>
                  <td align="right"><xsl:value-of select="ReOrderQuantity"/></td>
                  <td align="right"><xsl:value-of select="QtyOnHand"/></td>
                  <td align="right">
                                    <xsl:call-template name="GetUnitCost">
                              <xsl:with-param name="catalogUnitCost" select="$catalogUnitCost"/>
                              <xsl:with-param name="boxedUnitCost" select="$boxedUnitCost"/>
                              <xsl:with-param name="volumeUnitCost" select="$volumeUnitCost"/>
                            </xsl:call-template>                  
                  </td>
                  <td align="right">
                                        <xsl:call-template name="GetTotalCost">
                                  <xsl:with-param name="catalogUnitCost" select="$catalogUnitCost"/>
                                  <xsl:with-param name="boxedUnitCost" select="$boxedUnitCost"/>
                                  <xsl:with-param name="volumeUnitCost" select="$volumeUnitCost"/>
                                  <xsl:with-param name="qtyOnHand" select="$qtyOnHand"/>
                                </xsl:call-template>                  
                  </td>
                  <!--<td align="right"><xsl:value-of select="format-number(itemQty * itemPrice, '$##,##0.00' )"/></td-->
            </tr>
            </xsl:if>
            
        </xsl:for-each>    
             </table>
          </td>
        </tr>  
         </table>   
   </body>
   </html>
   </xsl:template>   
    <xsl:template name="GetUnitCost">
      <xsl:param name="catalogUnitCost"/>
      <xsl:param name="boxedUnitCost"/>
      <xsl:param name="volumeUnitCost"/>
      <xsl:choose>
      <xsl:when test="$boxedUnitCost &gt; 0">
        <xsl:value-of select="format-number($boxedUnitCost, '$##,##0.00')"/>
      </xsl:when>
      <xsl:when test="$volumeUnitCost &gt; 0">
        <xsl:value-of select="format-number($volumeUnitCost, '$##,##0.00')"/>
      </xsl:when>
      <xsl:when test="$catalogUnitCost &gt; 0">
        <xsl:value-of select="format-number($catalogUnitCost, '$##,##0.00')"/>
      </xsl:when>
      <xsl:otherwise>
        <xsl:value-of select="format-number(0, '$##,##0.00')"/>
      </xsl:otherwise>
    </xsl:choose>
  </xsl:template>
  <xsl:template name="GetTotalCost">
      <xsl:param name="catalogUnitCost"/>
      <xsl:param name="boxedUnitCost"/>
      <xsl:param name="volumeUnitCost"/>
      <xsl:param name="qtyOnHand"/>
      <xsl:choose>
      <xsl:when test="$boxedUnitCost &gt; 0">
        <xsl:value-of select="format-number($boxedUnitCost * $qtyOnHand, '$##,##0.00')"/>
      </xsl:when>
      <xsl:when test="$volumeUnitCost &gt; 0">
        <xsl:value-of select="format-number($volumeUnitCost * $qtyOnHand, '$##,##0.00')"/>
      </xsl:when>
      <xsl:when test="$catalogUnitCost &gt; 0">
        <xsl:value-of select="format-number($catalogUnitCost * $qtyOnHand, '$##,##0.00')"/>
      </xsl:when>
      <xsl:otherwise>
        <xsl:value-of select="format-number(0, '$##,##0.00')"/>
      </xsl:otherwise>
    </xsl:choose>
  </xsl:template>
    <xsl:template name="GetVendor">
      <xsl:param name="catalogVendorId"/>
      <xsl:param name="boxedVendorId"/>
      <xsl:param name="volumeVendorId"/>
      <xsl:param name="vendors"/>
      <xsl:choose>
      <xsl:when test="$catalogVendorId">
        <xsl:value-of select="$vendors/Vendor[@Id = $catalogVendorId]/Name"/>
      </xsl:when>
      <xsl:when test="$boxedVendorId">
        <xsl:value-of select="$vendors/Vendor[@Id = $boxedVendorId]/Name"/>
      </xsl:when>
      <xsl:when test="$volumeVendorId">
        <xsl:value-of select="$vendors/Vendor[@Id = $volumeVendorId]/Name"/>
      </xsl:when>
    </xsl:choose>
  </xsl:template>
</xsl:stylesheet>

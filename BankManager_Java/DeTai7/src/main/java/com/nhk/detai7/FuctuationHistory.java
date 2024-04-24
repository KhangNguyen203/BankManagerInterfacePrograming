/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.nhk.detai7;

import java.util.List;

/**
 *
 * @author 84355
 */
public interface FuctuationHistory{
    void addFuctuation(GiaoDich gd);
    List<GiaoDich> getFuctuations();
}
